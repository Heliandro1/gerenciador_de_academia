using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Academy
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hand, int wmsg, int wparam, int lparam);
        DataTable dados = new DataTable();
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtSenha.Text;
            List<Base.SQLParametros> P = new List<Base.SQLParametros>();
            P.Add(new Base.SQLParametros("@username", username));
            P.Add(new Base.SQLParametros("@password", password));
            if (username == "" || password == "")
            {
                MessageBox.Show("Usuário e ou senha inválidos");
                txtSenha.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
                return;
            }
            dados = Base.Query("SELECT * FROM Users WHERE T_USERNAME = @username AND T_SENHAUSUARIO = @password", P);
            if (dados.Rows.Count == 1)
            {
                FrmMain.text[0] = dados.Rows[0].Field<string>("T_NOMEUSUARIO");
                FrmMain.text[1] = dados.Rows[0].ItemArray[5].ToString();
                Globals.Loggedin = true;
                Globals.Level = dados.Rows[0].Field<int>("N_NIVELUSUARIO");
                Hide();
                FrmMain f = new FrmMain();
                if (Globals.Level >= 2)
                {
                    foreach (Control item in f.Controls)
                        item.BackColor = Color.FromArgb(46, 76, 126);

                }
                f.ShowDialog();
            }
            else
            {
                txtUsername.Clear();
                txtUsername.Focus();
                MessageBox.Show("Combinação Password-Username não encontrada!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
                txtSenha.PasswordChar = '\0';
            else
                txtSenha.PasswordChar = '*';
            
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
