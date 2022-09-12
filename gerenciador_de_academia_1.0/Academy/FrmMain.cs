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
    public partial class FrmMain : Form
    {
        private static Form AcctiveForm = null;
        private static Panel PM = null;
        public static string[] text =new string[2];
        public FrmMain()
        {
            InitializeComponent();
            PM = MainPanel;
        }
        
        private void HideSub(params Panel[] sub)
        {
            foreach (var item in sub)
                if (item.Visible == true)
                    item.Visible = false;
        }
        public static void OpenForm(Form Form, int level)
        {
           
            if (Globals.Loggedin)
            {
                if (Globals.Level >= level)
                {
                    if (AcctiveForm != null)
                        AcctiveForm.Close();
                    AcctiveForm = Form;
                    AcctiveForm.TopLevel = false;
                    AcctiveForm.Dock = DockStyle.Fill;
                    PM.Controls.Add(AcctiveForm);
                    PM.Tag = AcctiveForm;
                    AcctiveForm.BringToFront();
                    AcctiveForm.Show();
                    PM.Show();
                }
                else
                {
                    MessageBox.Show("Acess Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário Logado");
            }
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", 
                "ATENTION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
          
            lblAcesso.Text = "0";
            lblUsuario.Text = "---";
            pbLed.Image = Properties.Resources.cancel;
            Globals.Loggedin = false;
            Globals.Level = 0;
            Hide();
            Login log = new Login();
            log.ShowDialog();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblAcesso.Text = text[0];
            lblUsuario.Text = text[1];
            foreach (var item in PMenu.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                item.Text = "";
            }
            PMenu.Width = 47;
            pbLog.Visible = false;
            HideSub(SubLearner, SubMain, SubUsers);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            HideSub(SubLearner, SubMain, SubUsers);
            if (PMenu.Width == 47)
            {
                List<string> textos = new List<string>() { "Learners", "Users", "Maintenance", "Log Out" };
                for (int i = 0; i < textos.Count; i++)
                    PMenu.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().Reverse().ToList()[i].Text = textos[i];
                PMenu.Width = 267;
                pbLog.Visible = true;
            }
            else
            {
                foreach (var item in PMenu.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
                    item.Text = "";
                PMenu.Width = 47;
                pbLog.Visible = false;
            }
        }

        private void btnLearner_Click(object sender, EventArgs e)
        {
            if (SubLearner.Visible == false)
            {
                SubLearner.Visible = true;
                HideSub(SubMain, SubUsers);
            }
            else
            {
                SubLearner.Visible = false;
                HideSub(SubMain, SubUsers);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (SubUsers.Visible == false)
            {
                SubUsers.Visible = true;
                HideSub(SubMain, SubLearner);
            }
            else
            {
                SubUsers.Visible = false;
                HideSub(SubMain, SubLearner);
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            if (SubMain.Visible == false)
            {
                SubMain.Visible = true;
                HideSub(SubUsers, SubLearner);
            }
            else
            {
                SubMain.Visible = false;
                HideSub(SubUsers, SubLearner);
            }
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmNewUser(), 1);
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmUsersManager(), 1);
        }

        private void btnNewLearner_Click(object sender, EventArgs e)
        {
            if (Globals.Loggedin)
            {
                OpenForm(new FrmNewLearner(), 1);
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário Logado");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                btnMax.BackgroundImage = Properties.Resources.res;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnMax.BackgroundImage = Properties.Resources.max;
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void btnHour_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHours(), 2);
        }

        private void btnTeachersManager_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTeachersManager(), 2);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmClassManager(), 2);
        }

        private void btnLearnersManager_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmLearnersManager(), 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Base.CompactDataBase();
            Application.Exit();
        }
    }
}
