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
    public partial class FrmUsersManager : Form
    {
        public FrmUsersManager()
        {
            InitializeComponent();
        }

        private void FrmUsersManager_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = Base.GetAllUsersIdName();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);
            int count = dgv.SelectedRows.Count;
            if (count > 0)
            {
                DataTable dados = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dados = Base.GetUserData(id);
                txtUserId.Text = dados.Rows[0].Field<int>("N_IDUSUARIO").ToString();
                txtNome.Text = dados.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                txtUserName.Text = dados.Rows[0].Field<string>("T_USERNAME").ToString();
                txtPassword.Text = dados.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                switch (dados.Rows[0].Field<string>("T_STATUSUSUARIO").ToString())
                {
                    case "A": cmbStatus.SelectedIndex = 0;
                        break;
                    case "B": cmbStatus.SelectedIndex = 1;
                        break;
                    default: cmbStatus.SelectedIndex = 2;
                        break;
                }
                nupLevel.Value = dados.Rows[0].Field<int>("N_NIVELUSUARIO");
            }
           
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmMain.OpenForm(new FrmNewUser(), 1);
            dgvUsers.DataSource = Base.GetAllUsersIdName();
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            int line = dgvUsers.SelectedRows[0].Index;
            User user = new User();
            user.IdUser = Convert.ToInt32(txtUserId.Text);
            user.UserName = txtUserName.Text;
            user.Name = txtNome.Text;
            user.Password = txtPassword.Text;
            user.Status = cmbStatus.Text[0].ToString();
            user.Level = Convert.ToInt32(Math.Round(nupLevel.Value, 0));
            Base.UpdateUserData(user);
            dgvUsers[1, line].Value = txtNome.Text;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Base.DeleteUserData(txtUserId.Text);
            dgvUsers.Rows.Remove(dgvUsers.CurrentRow);
        }
    }
}
