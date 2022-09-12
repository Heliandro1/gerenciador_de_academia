using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class FrmTeachersManager : Form
    {
        public FrmTeachersManager()
        {
            InitializeComponent();
        }

        private void FrmTeachersManager_Load(object sender, EventArgs e)
        {
            dgvTeachers.DataSource = Base.Query(@"SELECT N_IDPROFESSOR AS ID, 
                                                T_NOMEPROFESSOR AS PROFESSOR, 
                                                T_TELEFONE AS TELEFONE 
                                                FROM PROFESSORES 
                                                ORDER BY N_IDPROFESSOR");

        }

        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dados = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dados = Base.Query($"SELECT * FROM PROFESSORES WHERE N_IDPROFESSOR = {id}");
                txtTeacherId.Text = dados.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                txtNome.Text = dados.Rows[0].Field<string>("T_NOMEPROFESSOR");
                txtPhone.Text = dados.Rows[0].Field<string>("T_TELEFONE");
            }
            

        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            txtTeacherId.Clear();
            txtPhone.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            List<Base.SQLParametros> p = new List<Base.SQLParametros>()
            {
                new Base.SQLParametros("@nome", txtNome.Text),
                new Base.SQLParametros("@phone", txtPhone.Text)
            };
            if (txtTeacherId.Text == "")
                Base.Crud("INSERT INTO PROFESSORES (T_NOMEPROFESSOR, T_TELEFONE) VALUES(@nome, @phone)", p);
            else
            {
                p.Add(new Base.SQLParametros("@id", txtTeacherId.Text));
                Base.Crud("UPDATE PROFESSORES SET T_NOMEPROFESSOR = @nome, T_TELEFONE = @phone WHERE N_IDPROFESSOR = @id", p);
            }
            dgvTeachers.DataSource = Base.Query(@"SELECT N_IDPROFESSOR AS ID, 
                                                T_NOMEPROFESSOR AS PROFESSOR, 
                                                T_TELEFONE AS TELEFONE 
                                                FROM PROFESSORES 
                                                ORDER BY N_IDPROFESSOR");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this teacher?",
                "ATENTION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Base.Crud($"DELETE FROM Professores WHERE N_IDPROFESSOR = {txtTeacherId.Text}");
            dgvTeachers.Rows.Remove(dgvTeachers.CurrentRow);
        }
    }
}
