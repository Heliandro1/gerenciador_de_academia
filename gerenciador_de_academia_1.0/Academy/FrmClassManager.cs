using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Academy
{
    public partial class FrmClassManager : Form
    {
        string selectedId;
        int mode = 0;
        public FrmClassManager()
        {
            InitializeComponent();
        }

        private void FrmClassManager_Load(object sender, EventArgs e)
        {
            dgvClass.DataSource = Base.Query(@"SELECT Turmas.N_IDTURMA AS ID, 
                        Turmas.T_SIGLA AS SIGLA, 
                        Horarios.T_DSCHORARIO AS HOUR 
                        FROM Turmas
                        INNER JOIN Horarios ON Horarios.N_IDHORARIO = Turmas.N_IDHORARIO
                        ORDER BY SIGLA");
            
            cmbTeacher.Items.Clear();
            cmbTeacher.DataSource = Base.Query(@"SELECT T_NOMEPROFESSOR, 
                        N_IDPROFESSOR
                        FROM PROFESSORES 
                        ORDER BY N_IDPROFESSOR");
            cmbTeacher.DisplayMember = "T_NOMEPROFESSOR";
            cmbTeacher.ValueMember = "N_IDPROFESSOR";

            cmbStatus.Items.Clear();
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativa");
            status.Add("P", "Paralisada");
            status.Add("C", "Cancelada");
            cmbStatus.DataSource = new BindingSource(status, null);
            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";
            
            cmbHour.Items.Clear();
            cmbHour.DataSource = Base.Query(@"SELECT * FROM Horarios ORDER BY T_DSCHORARIO");
            cmbHour.DisplayMember = "T_DSCHORARIO";
            cmbHour.ValueMember = "N_IDHORARIO";
        }

        private void dgvClass_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.SelectedRows.Count > 0)
            {
                mode = 1;
                selectedId = dgvClass.Rows[dgvClass.SelectedRows[0].Index].Cells[0].Value.ToString();
                DataTable dados = Base.Query($@"SELECT T_SIGLA, 
                            N_IDPROFESSOR, 
                            N_MAXALUNOS, 
                            N_IDHORARIO, 
                            T_STATUS 
                            FROM Turmas WHERE N_IDTURMA = {selectedId}");
                txtClassName.Text = dados.Rows[0].Field<string>("T_SIGLA");
                cmbTeacher.SelectedValue = dados.Rows[0].Field<long>("N_IDPROFESSOR").ToString();
                nUpMaxLearners.Value = dados.Rows[0].Field<int>("N_MAXALUNOS");
                cmbStatus.SelectedValue = dados.Rows[0].Field<string>("T_STATUS");
                cmbHour.SelectedValue = dados.Rows[0].Field<int>("N_IDHORARIO").ToString();
                txtRest.Text = CalcRest();
            }
        }

        private string CalcRest()
        {
            DataTable dados = Base.Query($@"SELECT COUNT(N_IDALUNO) AS ID FROM Alunos WHERE T_STATUS = 'A' AND N_IDTURMA = {selectedId}");
            int rest = (int.Parse(Math.Round(nUpMaxLearners.Value, 0).ToString()) - int.Parse(dados.Rows[0].Field<int>("ID").ToString()));
            return rest.ToString();
        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            txtClassName.Clear();
            cmbTeacher.SelectedIndex = -1;
            nUpMaxLearners.Value = 0;
            cmbStatus.SelectedIndex = -1;
            cmbHour.SelectedIndex = -1;
            txtClassName.Focus();
            mode = 2;
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                string Q;
                List<Base.SQLParametros> p = new List<Base.SQLParametros>()
                {
                    new Base.SQLParametros("@sigla", txtClassName.Text),
                    new Base.SQLParametros("@idteacher", cmbTeacher.SelectedValue),
                    new Base.SQLParametros("@hourid", cmbHour.SelectedValue),
                    new Base.SQLParametros("@status", cmbStatus.SelectedValue),
                    new Base.SQLParametros("@classid", selectedId),
                    new Base.SQLParametros("@max", int.Parse(Math.Round(nUpMaxLearners.Value, 0).ToString()))
                };
                if (mode == 1)
                    Q = @"UPDATE Turmas 
                        SET T_SIGLA = @sigla, 
                        N_IDPROFESSOR = @idteacher, 
                        N_IDHORARIO = @hourid, 
                        T_STATUS = @status,
                        N_MAXALUNOS = @max 
                        WHERE N_IDTURMA = @classid";
                else
                    Q = @"INSERT INTO Turmas 
                        (T_SIGLA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS) 
                        VALUES (@sigla, @idteacher, @hourid, @max, @status)";
                int line = dgvClass.SelectedRows[0].Index;
                Base.Crud(Q, p);
                dgvClass.DataSource = Base.Query(@"SELECT Turmas.N_IDTURMA AS ID, 
                        Turmas.T_SIGLA AS SIGLA, 
                        Horarios.T_DSCHORARIO AS HOUR 
                        FROM Turmas
                        INNER JOIN Horarios ON Horarios.N_IDHORARIO = Turmas.N_IDHORARIO 
                        ORDER BY SIGLA");
                MessageBox.Show("Data Saved");
            }
        }

        private void btnDelClass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this class?", 
                "ATENTION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Base.Crud($"DELETE FROM Turmas WHERE N_IDTURMA = {selectedId}");
            dgvClass.Rows.Remove(dgvClass.CurrentRow);
        }

        private void nUpMaxLearners_ValueChanged(object sender, EventArgs e)
        {
            txtRest.Text = CalcRest();
        }

        private void btnImpressClass_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\School Classes Details"))
                Directory.CreateDirectory($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\School Classes Details");

            string filename = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\School Classes Details\{dgvClass.CurrentRow.Cells[1].Value.ToString()}.pdf";
            FileStream filepdf = new FileStream(filename, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter pdfwriter = PdfWriter.GetInstance(doc, filepdf);

            iTextSharp.text.Image log = iTextSharp.text.Image.GetInstance($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\img\Harvard_shield_wreath.svg.png");
            log.ScaleToFit(140f, 120f);
            log.Alignment = Element.ALIGN_CENTER;
            string datas = "";

            Paragraph p = new Paragraph(datas, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)FontStyle.Bold));
            p.Alignment = Element.ALIGN_CENTER;
            p.Add("\nClass Details\n\n");

            PdfPTable table = new PdfPTable(3);
            table.DefaultCell.FixedHeight = 20;
            table.AddCell("Class ID");
            table.AddCell("Class");
            table.AddCell("Hour");

            DataTable data = Base.Query(@"SELECT Turmas.N_IDTURMA AS ID, 
                        Turmas.T_SIGLA AS SIGLA, 
                        Horarios.T_DSCHORARIO AS HOUR 
                        FROM Turmas
                        INNER JOIN Horarios ON Horarios.N_IDHORARIO = Turmas.N_IDHORARIO
                        ORDER BY SIGLA");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                table.AddCell(data.Rows[i].Field<long>("ID").ToString());
                table.AddCell(data.Rows[i].Field<string>("SIGLA"));
                table.AddCell(data.Rows[i].Field<string>("HOUR"));
            }
            doc.Open();
            doc.Add(log);
            doc.Add(p);
            doc.Add(table);
            doc.Close();

            if (MessageBox.Show("Do you want to open the saved document?", 
                "ATENTION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            System.Diagnostics.Process.Start(filename);
        }
    }
}
