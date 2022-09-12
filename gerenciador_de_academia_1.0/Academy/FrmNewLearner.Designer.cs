namespace Academy
{
    partial class FrmNewLearner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewLearner));
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAddPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewLearner = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveAlteration = new Guna.UI2.WinForms.Guna2Button();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelClass = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelPlain = new Guna.UI2.WinForms.Guna2Button();
            this.txtPlain = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblPP = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
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
            this.txtName.Enabled = false;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(13, 246);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(425, 36);
            this.txtName.TabIndex = 40;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(9, 222);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 20);
            this.lblClassName.TabIndex = 48;
            this.lblClassName.Text = "Name";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.Black;
            this.lblClass.Location = new System.Drawing.Point(229, 339);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 20);
            this.lblClass.TabIndex = 47;
            this.lblClass.Text = "Class";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(11, 339);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnAddPhoto);
            this.panelBottom.Controls.Add(this.btnNewLearner);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnSaveAlteration);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 552);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(922, 53);
            this.panelBottom.TabIndex = 45;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BorderRadius = 3;
            this.btnAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPhoto.Enabled = false;
            this.btnAddPhoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnAddPhoto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(331, 3);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(158, 45);
            this.btnAddPhoto.TabIndex = 57;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnNewLearner
            // 
            this.btnNewLearner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewLearner.BorderRadius = 3;
            this.btnNewLearner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLearner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewLearner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewLearner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewLearner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewLearner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnNewLearner.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnNewLearner.ForeColor = System.Drawing.Color.White;
            this.btnNewLearner.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLearner.Image")));
            this.btnNewLearner.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewLearner.Location = new System.Drawing.Point(0, 3);
            this.btnNewLearner.Name = "btnNewLearner";
            this.btnNewLearner.Size = new System.Drawing.Size(158, 45);
            this.btnNewLearner.TabIndex = 9;
            this.btnNewLearner.Text = "New Learner";
            this.btnNewLearner.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewLearner.Click += new System.EventHandler(this.btnNewLearner_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BorderRadius = 3;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(495, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAlteration
            // 
            this.btnSaveAlteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAlteration.BorderRadius = 3;
            this.btnSaveAlteration.BorderThickness = -1;
            this.btnSaveAlteration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAlteration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAlteration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAlteration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveAlteration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveAlteration.Enabled = false;
            this.btnSaveAlteration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSaveAlteration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAlteration.ForeColor = System.Drawing.Color.White;
            this.btnSaveAlteration.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAlteration.Image")));
            this.btnSaveAlteration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveAlteration.Location = new System.Drawing.Point(164, 3);
            this.btnSaveAlteration.Name = "btnSaveAlteration";
            this.btnSaveAlteration.Size = new System.Drawing.Size(158, 45);
            this.btnSaveAlteration.TabIndex = 7;
            this.btnSaveAlteration.Text = "Save Editions";
            this.btnSaveAlteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaveAlteration.Click += new System.EventHandler(this.btnSaveAlteration_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 5;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Location = new System.Drawing.Point(13, 372);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(214, 36);
            this.cmbStatus.TabIndex = 42;
            // 
            // txtClass
            // 
            this.txtClass.BorderRadius = 5;
            this.txtClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClass.DefaultText = "";
            this.txtClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClass.Enabled = false;
            this.txtClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClass.Location = new System.Drawing.Point(233, 372);
            this.txtClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.PlaceholderText = "";
            this.txtClass.ReadOnly = true;
            this.txtClass.SelectedText = "";
            this.txtClass.Size = new System.Drawing.Size(425, 36);
            this.txtClass.TabIndex = 50;
            this.txtClass.Tag = "1";
            // 
            // btnSelClass
            // 
            this.btnSelClass.BorderRadius = 3;
            this.btnSelClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelClass.Enabled = false;
            this.btnSelClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSelClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelClass.ForeColor = System.Drawing.Color.White;
            this.btnSelClass.Location = new System.Drawing.Point(665, 372);
            this.btnSelClass.Name = "btnSelClass";
            this.btnSelClass.Size = new System.Drawing.Size(42, 36);
            this.btnSelClass.TabIndex = 10;
            this.btnSelClass.Text = "...";
            this.btnSelClass.Click += new System.EventHandler(this.btnSelClass_Click);
            // 
            // btnSelPlain
            // 
            this.btnSelPlain.BorderRadius = 3;
            this.btnSelPlain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelPlain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelPlain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelPlain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelPlain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelPlain.Enabled = false;
            this.btnSelPlain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSelPlain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPlain.ForeColor = System.Drawing.Color.White;
            this.btnSelPlain.Location = new System.Drawing.Point(447, 462);
            this.btnSelPlain.Name = "btnSelPlain";
            this.btnSelPlain.Size = new System.Drawing.Size(42, 36);
            this.btnSelPlain.TabIndex = 51;
            this.btnSelPlain.Text = "...";
            // 
            // txtPlain
            // 
            this.txtPlain.BorderRadius = 5;
            this.txtPlain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlain.DefaultText = "";
            this.txtPlain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlain.Enabled = false;
            this.txtPlain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlain.Location = new System.Drawing.Point(15, 462);
            this.txtPlain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.PasswordChar = '\0';
            this.txtPlain.PlaceholderText = "";
            this.txtPlain.ReadOnly = true;
            this.txtPlain.SelectedText = "";
            this.txtPlain.Size = new System.Drawing.Size(425, 36);
            this.txtPlain.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Plain";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(445, 246);
            this.txtPhone.Mask = "+000 000 000 000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 20);
            this.txtPhone.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(443, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Cell Phone Number";
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPhoto.Location = new System.Drawing.Point(13, 12);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(168, 158);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 56;
            this.pbPhoto.TabStop = false;
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP.ForeColor = System.Drawing.Color.Black;
            this.lblPP.Location = new System.Drawing.Point(12, 173);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(101, 20);
            this.lblPP.TabIndex = 57;
            this.lblPP.Text = "Profile Photo";
            // 
            // file
            // 
            this.file.Filter = "Photos(*JPG, *PNG) |*.jpg||*.png";
            // 
            // FrmNewLearner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 605);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSelPlain);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelClass);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.cmbStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewLearner";
            this.Text = "FrmNewLearner";
            this.Load += new System.EventHandler(this.FrmNewLearner_Load);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSaveAlteration;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2Button btnSelClass;
        private Guna.UI2.WinForms.Guna2Button btnSelPlain;
        private Guna.UI2.WinForms.Guna2TextBox txtPlain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnNewLearner;
        public Guna.UI2.WinForms.Guna2TextBox txtClass;
        private System.Windows.Forms.PictureBox pbPhoto;
        private Guna.UI2.WinForms.Guna2Button btnAddPhoto;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.OpenFileDialog file;
    }
}