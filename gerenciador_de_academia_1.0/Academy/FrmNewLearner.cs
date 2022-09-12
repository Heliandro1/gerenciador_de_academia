using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Academy
{
    public partial class FrmNewLearner : Form
    {
        string origin = "";
        string photo = "";
        string cdestin = "";
        public FrmNewLearner()
        {
            InitializeComponent();
        }

        private void FrmNewLearner_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>()
            {
                { "A", "Ativo" },
                { "B", "Bloqueado" },
                { "C", "Cancelado" }
            };
            cmbStatus.DataSource = new BindingSource(status, null);
            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";

        }

        private void btnNewLearner_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
                item.Enabled = true;
            foreach (Control item in panelBottom.Controls)
            {
                if (item == btnNewLearner)
                    item.Enabled = false;
                else
                    item.Enabled = true;
            }
            cmbStatus.SelectedIndex = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtPlain.Clear();
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtPlain.Clear();
            cmbStatus.SelectedIndex = -1;
            foreach (Control item in Controls)
            {
                item.Enabled = false;
            }

            panelBottom.Enabled = true;

            foreach (Control item in panelBottom.Controls)
            {
                if (item == btnNewLearner)
                    item.Enabled = true;
                else
                    item.Enabled = false;
            }
            txtName.Clear();
            txtPhone.Clear();
            txtPlain.Clear();

        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            if (cdestin == "")
            {
                MessageBox.Show("Please Add a profile photo", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cdestin != "")
            {
                try
                {
                    File.Copy(origin, cdestin, true);
                    pbPhoto.ImageLocation = cdestin;
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot localizate the selected photo! Please choose another one", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAddPhoto_Click(sender, e);
                    File.Copy(origin, cdestin, true);
                }
                List<Base.SQLParametros> p = new List<Base.SQLParametros>()
                {
                    new Base.SQLParametros("@nome", txtName.Text),
                    new Base.SQLParametros("@phone", txtPhone.Text),
                    new Base.SQLParametros("@status", cmbStatus.SelectedValue),
                    new Base.SQLParametros("@id", txtClass.Tag.ToString()),
                    new Base.SQLParametros("@photo", cdestin)
                };

                Base.Crud(@"INSERT INTO Alunos (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_PHOTO)
                        VALUES (@nome, @phone, @status, @id, @photo)", p);
                MessageBox.Show("New Learner inserted sucessfully", "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbPhoto.ImageLocation = "";
                txtName.Clear();
                txtPhone.Clear();
                txtPlain.Clear();
                txtClass.Clear();
                cmbStatus.SelectedIndex = -1;
                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }
                panelBottom.Enabled = true;
                foreach (Control item in panelBottom.Controls)
                {
                    if (item == btnNewLearner)
                        item.Enabled = true;
                    else
                        item.Enabled = false;
                }

            }
        }

        private void btnSelClass_Click(object sender, EventArgs e)
        {
            FrmSelectClass f = new FrmSelectClass(this);
            f.ShowDialog();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            origin = "";
            photo = "";
            cdestin = "";
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
                    btnAddPhoto_Click(sender, e);
            }
            pbPhoto.ImageLocation = origin;
        }
    }
}
