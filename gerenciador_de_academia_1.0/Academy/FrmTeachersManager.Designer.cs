namespace Academy
{
    partial class FrmTeachersManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeachersManager));
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblstarts = new System.Windows.Forms.Label();
            this.txtTeacherId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveAlteration = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewTeacher = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeachers.EnableHeadersVisualStyles = false;
            this.dgvTeachers.Location = new System.Drawing.Point(0, 60);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeachers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(986, 576);
            this.dgvTeachers.TabIndex = 27;
            this.dgvTeachers.SelectionChanged += new System.EventHandler(this.dgvTeachers_SelectionChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtNome);
            this.panelTop.Controls.Add(this.lblProf);
            this.panelTop.Controls.Add(this.txtPhone);
            this.panelTop.Controls.Add(this.lblstarts);
            this.panelTop.Controls.Add(this.txtTeacherId);
            this.panelTop.Controls.Add(this.lblId);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(986, 60);
            this.panelTop.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.BorderRadius = 5;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(328, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(260, 33);
            this.txtNome.TabIndex = 30;
            this.txtNome.TabStop = false;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.BackColor = System.Drawing.Color.Transparent;
            this.lblProf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.ForeColor = System.Drawing.Color.Black;
            this.lblProf.Location = new System.Drawing.Point(327, 0);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(75, 20);
            this.lblProf.TabIndex = 29;
            this.lblProf.Text = "Professor";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(670, 33);
            this.txtPhone.Mask = "+000 000 000 000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // lblstarts
            // 
            this.lblstarts.AutoSize = true;
            this.lblstarts.BackColor = System.Drawing.Color.Transparent;
            this.lblstarts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstarts.ForeColor = System.Drawing.Color.Black;
            this.lblstarts.Location = new System.Drawing.Point(666, 9);
            this.lblstarts.Name = "lblstarts";
            this.lblstarts.Size = new System.Drawing.Size(71, 20);
            this.lblstarts.TabIndex = 27;
            this.lblstarts.Text = "Telefone";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.BorderRadius = 5;
            this.txtTeacherId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeacherId.DefaultText = "";
            this.txtTeacherId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeacherId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeacherId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeacherId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeacherId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeacherId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeacherId.Location = new System.Drawing.Point(4, 24);
            this.txtTeacherId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.PasswordChar = '\0';
            this.txtTeacherId.PlaceholderText = "";
            this.txtTeacherId.ReadOnly = true;
            this.txtTeacherId.SelectedText = "";
            this.txtTeacherId.Size = new System.Drawing.Size(260, 33);
            this.txtTeacherId.TabIndex = 26;
            this.txtTeacherId.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 20);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Id";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDel);
            this.panelBottom.Controls.Add(this.btnSaveAlteration);
            this.panelBottom.Controls.Add(this.btnNewTeacher);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 636);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(986, 53);
            this.panelBottom.TabIndex = 26;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.BorderRadius = 3;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(328, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 45);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Delete Teacher";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnSaveAlteration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSaveAlteration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAlteration.ForeColor = System.Drawing.Color.White;
            this.btnSaveAlteration.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAlteration.Image")));
            this.btnSaveAlteration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveAlteration.Location = new System.Drawing.Point(164, 3);
            this.btnSaveAlteration.Name = "btnSaveAlteration";
            this.btnSaveAlteration.Size = new System.Drawing.Size(158, 45);
            this.btnSaveAlteration.TabIndex = 29;
            this.btnSaveAlteration.Text = "Save ";
            this.btnSaveAlteration.Click += new System.EventHandler(this.btnSaveAlteration_Click);
            // 
            // btnNewTeacher
            // 
            this.btnNewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewTeacher.BorderRadius = 3;
            this.btnNewTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewTeacher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnNewTeacher.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTeacher.ForeColor = System.Drawing.Color.White;
            this.btnNewTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTeacher.Image")));
            this.btnNewTeacher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewTeacher.Location = new System.Drawing.Point(0, 3);
            this.btnNewTeacher.Name = "btnNewTeacher";
            this.btnNewTeacher.Size = new System.Drawing.Size(158, 45);
            this.btnNewTeacher.TabIndex = 28;
            this.btnNewTeacher.Text = "New Teacher";
            this.btnNewTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewTeacher.Click += new System.EventHandler(this.btnNewTeacher_Click);
            // 
            // FrmTeachersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 689);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTeachersManager";
            this.Text = "FrmTeachersManager";
            this.Load += new System.EventHandler(this.FrmTeachersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblstarts;
        private Guna.UI2.WinForms.Guna2TextBox txtTeacherId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnSaveAlteration;
        private Guna.UI2.WinForms.Guna2Button btnNewTeacher;
    }
}