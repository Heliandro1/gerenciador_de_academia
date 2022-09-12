namespace Academy
{
    partial class FrmLearnersManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLearnersManager));
            this.dgvLearners = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lbldouble = new System.Windows.Forms.Label();
            this.btnImpressWallet = new Guna.UI2.WinForms.Guna2Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveAlteration = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinance = new Guna.UI2.WinForms.Guna2Button();
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.saver = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearners)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLearners
            // 
            this.dgvLearners.AllowUserToAddRows = false;
            this.dgvLearners.AllowUserToDeleteRows = false;
            this.dgvLearners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLearners.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvLearners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLearners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLearners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearners.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLearners.EnableHeadersVisualStyles = false;
            this.dgvLearners.Location = new System.Drawing.Point(0, 0);
            this.dgvLearners.MultiSelect = false;
            this.dgvLearners.Name = "dgvLearners";
            this.dgvLearners.ReadOnly = true;
            this.dgvLearners.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLearners.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLearners.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvLearners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLearners.Size = new System.Drawing.Size(495, 663);
            this.dgvLearners.TabIndex = 30;
            this.dgvLearners.SelectionChanged += new System.EventHandler(this.dgvLearners_SelectionChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pbPhoto);
            this.panelTop.Controls.Add(this.lbldouble);
            this.panelTop.Controls.Add(this.btnImpressWallet);
            this.panelTop.Controls.Add(this.lblClass);
            this.panelTop.Controls.Add(this.cmbClass);
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Controls.Add(this.cmbStatus);
            this.panelTop.Controls.Add(this.txtPhone);
            this.panelTop.Controls.Add(this.lblphone);
            this.panelTop.Controls.Add(this.txtName);
            this.panelTop.Controls.Add(this.lblName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTop.Location = new System.Drawing.Point(495, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(625, 663);
            this.panelTop.TabIndex = 28;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbPhoto.Location = new System.Drawing.Point(452, 30);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(168, 196);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 53;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.DoubleClick += new System.EventHandler(this.pbPhoto_DoubleClick);
            // 
            // lbldouble
            // 
            this.lbldouble.AutoSize = true;
            this.lbldouble.BackColor = System.Drawing.Color.Transparent;
            this.lbldouble.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldouble.ForeColor = System.Drawing.Color.Black;
            this.lbldouble.Location = new System.Drawing.Point(304, 6);
            this.lbldouble.Name = "lbldouble";
            this.lbldouble.Size = new System.Drawing.Size(309, 20);
            this.lbldouble.TabIndex = 52;
            this.lbldouble.Text = "Double Click to change the profile photo";
            // 
            // btnImpressWallet
            // 
            this.btnImpressWallet.BorderRadius = 3;
            this.btnImpressWallet.BorderThickness = -1;
            this.btnImpressWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpressWallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImpressWallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImpressWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImpressWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImpressWallet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnImpressWallet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpressWallet.ForeColor = System.Drawing.Color.White;
            this.btnImpressWallet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnImpressWallet.Location = new System.Drawing.Point(16, 271);
            this.btnImpressWallet.Name = "btnImpressWallet";
            this.btnImpressWallet.Size = new System.Drawing.Size(604, 36);
            this.btnImpressWallet.TabIndex = 31;
            this.btnImpressWallet.Text = "Impress Wallet";
            this.btnImpressWallet.Click += new System.EventHandler(this.btnImpressWallet_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.Black;
            this.lblClass.Location = new System.Drawing.Point(12, 165);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(62, 20);
            this.lblClass.TabIndex = 50;
            this.lblClass.Text = "Classes";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Transparent;
            this.cmbClass.BorderRadius = 5;
            this.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbClass.ItemHeight = 30;
            this.cmbClass.Location = new System.Drawing.Point(14, 198);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(417, 36);
            this.cmbClass.TabIndex = 49;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(9, 79);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 5;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Location = new System.Drawing.Point(11, 112);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(214, 36);
            this.cmbStatus.TabIndex = 47;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(231, 112);
            this.txtPhone.Mask = "+000 000 000 000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.BackColor = System.Drawing.Color.Transparent;
            this.lblphone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.Black;
            this.lblphone.Location = new System.Drawing.Point(227, 79);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(150, 20);
            this.lblphone.TabIndex = 27;
            this.lblphone.Text = "Cell Phone Number";
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 5;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(13, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(417, 33);
            this.txtName.TabIndex = 26;
            this.txtName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(9, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDel);
            this.panelBottom.Controls.Add(this.btnSaveAlteration);
            this.panelBottom.Controls.Add(this.btnFinance);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 663);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1120, 53);
            this.panelBottom.TabIndex = 29;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BorderRadius = 3;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(798, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 53);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Delete Learner";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSaveAlteration
            // 
            this.btnSaveAlteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAlteration.BorderRadius = 3;
            this.btnSaveAlteration.BorderThickness = -1;
            this.btnSaveAlteration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAlteration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAlteration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAlteration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveAlteration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveAlteration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSaveAlteration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAlteration.ForeColor = System.Drawing.Color.White;
            this.btnSaveAlteration.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAlteration.Image")));
            this.btnSaveAlteration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveAlteration.Location = new System.Drawing.Point(962, 0);
            this.btnSaveAlteration.Name = "btnSaveAlteration";
            this.btnSaveAlteration.Size = new System.Drawing.Size(158, 53);
            this.btnSaveAlteration.TabIndex = 29;
            this.btnSaveAlteration.Text = "Save ";
            this.btnSaveAlteration.Click += new System.EventHandler(this.btnSaveAlteration_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinance.BorderRadius = 3;
            this.btnFinance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnFinance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFinance.Location = new System.Drawing.Point(634, 0);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(158, 53);
            this.btnFinance.TabIndex = 28;
            this.btnFinance.Text = "Finances";
            // 
            // file
            // 
            this.file.Filter = "Photos(*JPG, *PNG) |*.jpg||*.png";
            // 
            // saver
            // 
            this.saver.Filter = "PDF Files|*.pdf";
            // 
            // FrmLearnersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 716);
            this.Controls.Add(this.dgvLearners);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLearnersManager";
            this.Text = "FrmLearnersManager";
            this.Load += new System.EventHandler(this.FrmLearnersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearners)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLearners;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblphone;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnSaveAlteration;
        private Guna.UI2.WinForms.Guna2Button btnFinance;
        private System.Windows.Forms.Label lblClass;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClass;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label lbldouble;
        private Guna.UI2.WinForms.Guna2Button btnImpressWallet;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.OpenFileDialog file;
        private System.Windows.Forms.SaveFileDialog saver;
    }
}