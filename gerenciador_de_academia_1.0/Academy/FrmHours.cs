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
    public partial class FrmHours : Form
    {
        public FrmHours()
        {
            InitializeComponent();
        }

        private void FrmHours_Load(object sender, EventArgs e)
        {
            dgvHours.DataSource = Base.Query(@"SELECT N_IDHORARIO as  [Hour ID], T_DSCHORARIO as Hour FROM Horarios ORDER BY T_DSCHORARIO");
            
        }

        private void dgvHours_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dados = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                List<Base.SQLParametros> p = new List<Base.SQLParametros>() { new Base.SQLParametros("@id", id) };
                dados = Base.Query("SELECT * FROM Horarios WHERE N_IDHORARIO = @id", p);
                txthourId.Text = dados.Rows[0].Field<int>("N_IDHORARIO").ToString();
                txtDschour.Text = dados.Rows[0].Field<string>("T_DSCHORARIO");
                long a = 1;
                string b = a.ToString();
            }
            
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            txthourId.Clear();
            txtDschour.Clear();
            txtDschour.Focus();
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            List<Base.SQLParametros> p = new List<Base.SQLParametros>() { new Base.SQLParametros("@hora", txtDschour.Text) };
            if (txthourId.Text == "")  
                Base.Crud("INSERT INTO HORARIOS (T_DSCHORARIO) VALUES(@hora)", p);
            else
            {
                p.Add(new Base.SQLParametros("@id", txthourId.Text));
                Base.Crud("UPDATE HORARIOS SET T_DSCHORARIO = @hora WHERE N_IDHORARIO = @id", p);
            }
            dgvHours.DataSource = Base.Query(@"SELECT N_IDHORARIO as  [Hour ID], T_DSCHORARIO as Hour FROM Horarios ORDER BY T_DSCHORARIO");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this hour?", 
                "ATENTION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Base.Crud($"DELETE FROM HORARIOS WHERE N_IDHORARIO = {txthourId.Text}");
            dgvHours.Rows.Remove(dgvHours.CurrentRow);
        }
    }
}
