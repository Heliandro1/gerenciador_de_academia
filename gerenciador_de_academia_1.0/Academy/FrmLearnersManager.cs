using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Academy
{
    public partial class FrmLearnersManager : Form
    {
        string atualclass = "";
        string selectedId = "";
        string Class = "";
       
        public FrmLearnersManager()
        {
            InitializeComponent();
        }

        private void FrmLearnersManager_Load(object sender, EventArgs e)
        {
            dgvLearners.DataSource = Base.Query(@"SELECT N_IDALUNO AS ID, T_NOMEALUNO AS ALUNO FROM Alunos");
            txtName.Text = dgvLearners.Rows[dgvLearners.SelectedRows[0].Index].Cells[1].Value.ToString();
            DataTable d = Base.Query("SELECT N_IDTURMA, N_MAXALUNOS, T_SIGLA FROM TURMAS");
            d.Columns.Add("Qtt", typeof(int));
            d.Columns.Add("Rest", typeof(int));
            d.Columns.Add("Display", typeof(string));
            for (int i = 0; i < d.Rows.Count; i++)
            {
                d.Rows[i]["Qtt"] = Base.Query($@"SELECT COUNT(N_IDALUNO) AS [Max] FROM ALUNOS 
                                    WHERE N_IDTURMA = {d.Rows[i].Field<long>("N_IDTURMA").ToString()} AND T_STATUS = 'A'").Rows[0].Field<int>("Max");
                d.Rows[i]["Rest"] = int.Parse(d.Rows[i]["N_MAXALUNOS"].ToString()) - int.Parse(d.Rows[i]["Qtt"].ToString());
                d.Rows[i]["Display"] = $"Rest {d.Rows[i]["Rest"].ToString()} / {d.Rows[i]["T_SIGLA"].ToString()}";
            }
            cmbClass.Items.Clear();
            cmbClass.DataSource = d;
            cmbClass.DisplayMember = "Display";
            cmbClass.ValueMember = "N_IDTURMA";
            Dictionary<string, string> status = new Dictionary<string, string>()
            {
                {"A", "Ativo" },
                {"B", "Bloqueado" },
                {"C", "Cancelado" }
            };
            cmbStatus.DataSource = new BindingSource(status, null);
            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";
            Class = cmbClass.Text;
            atualclass = cmbClass.Text;
            selectedId = dgvLearners.Rows[0].Cells[0].Value.ToString();
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            Class = cmbClass.Text;
            if (atualclass != Class)
            {
                string[] c = Class.Split(' ');
                int rest = int.Parse(c[1]);
                if (rest < 1)
                {
                    MessageBox.Show("There isn´t a available space to add a learner in this class", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbClass.Focus();
                    return;
                }
                List<Base.SQLParametros> p = new List<Base.SQLParametros>()
                {
                     new Base.SQLParametros("@name", txtName.Text),
                     new Base.SQLParametros("@status", cmbStatus.SelectedValue),
                     new Base.SQLParametros("@phone", txtPhone.Text),
                     new Base.SQLParametros("@id", txtName.Text),
                      new Base.SQLParametros("@idturma", selectedId),
                };
                Base.Crud(@"UPDATE ALUNOS SET 
                            T_NOMEALUNO = @name, 
                            T_TELEFONE = @phone, 
                            N_IDTURMA = @idturma, 
                            T_STATUS = @status 
                            WHERE N_IDALUNO = @id", p);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this learner?", 
                "ATENTION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (File.Exists(pbPhoto.ImageLocation))
            {
                File.Delete(pbPhoto.ImageLocation);
            }
            Base.Crud($"DELETE FROM ALUNOS WHERE N_IDALUNO = {selectedId}");
            dgvLearners.DataSource = Base.Query(@"SELECT N_IDALUNO AS ID, T_NOMEALUNO AS ALUNO FROM Alunos");

        }

        private void dgvLearners_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.SelectedRows.Count > 0)
            {
                selectedId = dgvLearners.Rows[0].Cells[0].ToString();
                selectedId = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                txtName.Text = dgvLearners.Rows[dgvLearners.SelectedRows[0].Index].Cells[1].Value.ToString();

                DataTable data = Base.Query($"SELECT N_IDALUNO, T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_PHOTO FROM ALUNOS WHERE N_IDALUNO = {selectedId}");
                txtName.Text = data.Rows[0].Field<string>("T_NOMEALUNO");
                txtPhone.Text = data.Rows[0].Field<string>("T_TELEFONE");
                cmbStatus.SelectedValue = data.Rows[0].Field<string>("T_STATUS");
                cmbClass.SelectedValue = data.Rows[0].Field<long>("N_IDTURMA");
                atualclass = cmbClass.Text;
                pbPhoto.ImageLocation = data.Rows[0].Field<string>("T_PHOTO");
            }
        }

        private void pbPhoto_DoubleClick(object sender, EventArgs e)
        {
            string origin = "";
            string photo = "";
            string cdestin = "";
            if (!Directory.Exists($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Photos"))
                Directory.CreateDirectory($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Photos");

            if (file.ShowDialog() == DialogResult.Cancel)
                return;
            origin = file.FileName;
            photo = file.SafeFileName;
            cdestin = $@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Photos\{photo}";
            if (File.Exists(cdestin))
            {
                if (MessageBox.Show("This file already exists do you want to replace?",
                "ATENTION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                    pbPhoto_DoubleClick(sender, e);
            }
            File.Copy(origin, cdestin, true);
            List<Base.SQLParametros> p = new List<Base.SQLParametros>()
            {
                new Base.SQLParametros("@photo", cdestin),
                new Base.SQLParametros("@id", selectedId)
            };
            Base.Crud($@"UPDATE Alunos SET T_PHOTO = @photo WHERE N_IDALUNO = @id", p);
            pbPhoto.ImageLocation = Base.Query("SELECT T_PHOTO FROM ALUNOS WHERE N_IDALUNO = @id", p).Rows[0].Field<string>("T_PHOTO");
            dgvLearners.DataSource = Base.Query(@"SELECT N_IDALUNO AS ID, T_NOMEALUNO AS ALUNO FROM Alunos");
        }

        private void btnImpressWallet_Click(object sender, EventArgs e)
        {
            if (saver.ShowDialog() == DialogResult.Cancel)
                return;

            DataTable data = Base.Query($@"SELECT * FROM ALUNOS WHERE N_IDALUNO = {selectedId}");

            FileStream filepdf = new FileStream(saver.FileName, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter pdfwriter = PdfWriter.GetInstance(doc, filepdf);
            doc.Open();

            iTextSharp.text.Image log = iTextSharp.text.Image.GetInstance($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\img\Harvard_shield_wreath.svg.png");
            log.ScaleToFit(140f, 120f);
            log.Alignment = Element.ALIGN_CENTER;
            doc.Add(log);
            
            log = iTextSharp.text.Image.GetInstance(pbPhoto.ImageLocation);
            log.ScaleToFit(120f, 140f);
            float a = PageSize.A4.Height * 90 / 10;
            log.SetAbsolutePosition(PageSize.A4.Width * 80 / 100, PageSize.A4.Height * 82 / 100);
            doc.Add(log);
            
            string datas = "";

            Paragraph p = new Paragraph(datas, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)FontStyle.Bold));
            p.Alignment = Element.ALIGN_JUSTIFIED;
            p.Add("\n\n\n\n\n\nLearner File of Informations");
            p.Add($"\nLearner ID: {data.Rows[0].Field<long>("N_IDALUNO")}");
            p.Add($"\nLearner Name: {data.Rows[0].Field<string>("T_NOMEALUNO")}");
            p.Add($"\nCell Phone: {data.Rows[0].Field<string>("T_TELEFONE")}");
            p.Add($"\nStatus: {data.Rows[0].Field<string>("T_STATUS")}");
            p.Add($"\nClass ID: {data.Rows[0].Field<long>("N_IDTURMA")}");
                doc.Add(p);
            
           
           
            doc.Close();

            if (MessageBox.Show("Do you want to open the saved document?",
                "ATENTION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            System.Diagnostics.Process.Start(saver.FileName);
        }
    }
}
