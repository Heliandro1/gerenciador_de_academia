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
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtNome.Text;
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.Status = cmbStatus.Text[0].ToString();
            user.Level = Convert.ToInt32(Math.Round(nupLevel.Value, 0));
            if (Base.NewUser(user))
            {
                foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                {
                    item.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                item.Clear();
            }
            nupLevel.Value = 0;
            cmbStatus.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                item.Clear();
            }
            nupLevel.Value = 0;
            cmbStatus.SelectedIndex = 0;
            txtNome.Focus();
        }
    }
}
