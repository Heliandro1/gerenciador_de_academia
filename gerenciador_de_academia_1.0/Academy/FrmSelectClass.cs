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
    public partial class FrmSelectClass : Form
    {
        FrmNewLearner f;
        public FrmSelectClass(FrmNewLearner f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void FrmSelectClass_Load(object sender, EventArgs e)
        {
            dgvTeachers.DataSource = Base.Query(@"SELECT 
                        Turmas.N_IDTURMA AS ID, 
                        Turmas.T_SIGLA AS SIGLA, 
                        Horarios.T_DSCHORARIO AS HOUR, 
                        Professores.T_NOMEPROFESSOR AS [TEACHER NAME],
                        Turmas.N_MAXALUNOS AS [MAX ALUNOS]
                        FROM Turmas 
                        INNER JOIN Professores ON Professores.N_IDPROFESSOR = Turmas.N_IDPROFESSOR 
                        INNER JOIN Horarios on Horarios.N_IDHORARIO = Turmas.N_IDHORARIO");
            DataTable data;
            dgvTeachers.Columns.Add("Max", "QUANTITY OF LEARNERS");
            for (int i = 0; i < dgvTeachers.Rows.Count; i++)
            {
                data = Base.Query($@"SELECT COUNT(N_IDALUNO) AS [Max] FROM ALUNOS 
                                    WHERE N_IDTURMA = {dgvTeachers[0, i].Value.ToString()} AND T_STATUS = 'A'");
                dgvTeachers[5, i].Value = data.Rows[0].Field<int>("Max").ToString();
            }

        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int max = 0;
            int qtd = 0;
            max = int.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtd = int.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if (qtd >= max)
            {
                MessageBox.Show("There isn´t a disponible space to add an leaner in this class", "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                f.txtClass.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                f.txtClass.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
