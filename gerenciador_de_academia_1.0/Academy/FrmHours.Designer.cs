namespace Academy
{
    partial class FrmHours
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHours));
            this.panelTop = new System.Windows.Forms.Panel();
            this.txthourId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblstarts = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvHours = new System.Windows.Forms.DataGridView();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveAlteration = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtDschour = new System.Windows.Forms.MaskedTextBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtDschour);
            this.panelTop.Controls.Add(this.lblstarts);
            this.panelTop.Controls.Add(this.txthourId);
            this.panelTop.Controls.Add(this.lbluserid);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1113, 60);
            this.panelTop.TabIndex = 1;
            // 
            // txthourId
            // 
            this.txthourId.BorderRadius = 5;
            this.txthourId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthourId.DefaultText = "";
            this.txthourId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthourId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthourId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthourId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthourId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthourId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthourId.Location = new System.Drawing.Point(4, 24);
            this.txthourId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthourId.Name = "txthourId";
            this.txthourId.PasswordChar = '\0';
            this.txthourId.PlaceholderText = "";
            this.txthourId.ReadOnly = true;
            this.txthourId.SelectedText = "";
            this.txthourId.Size = new System.Drawing.Size(260, 33);
            this.txthourId.TabIndex = 26;
            this.txthourId.TabStop = false;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.BackColor = System.Drawing.Color.Transparent;
            this.lbluserid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.ForeColor = System.Drawing.Color.Black;
            this.lbluserid.Location = new System.Drawing.Point(3, 0);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(62, 20);
            this.lbluserid.TabIndex = 25;
            this.lbluserid.Text = "Hour Id";
            // 
            // lblstarts
            // 
            this.lblstarts.AutoSize = true;
            this.lblstarts.BackColor = System.Drawing.Color.Transparent;
            this.lblstarts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstarts.ForeColor = System.Drawing.Color.Black;
            this.lblstarts.Location = new System.Drawing.Point(366, 0);
            this.lblstarts.Name = "lblstarts";
            this.lblstarts.Size = new System.Drawing.Size(70, 20);
            this.lblstarts.TabIndex = 27;
            this.lblstarts.Text = "Starts at:";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDel);
            this.panelBottom.Controls.Add(this.btnSaveAlteration);
            this.panelBottom.Controls.Add(this.btnNewUser);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 673);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1113, 53);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvHours
            // 
            this.dgvHours.AllowUserToAddRows = false;
            this.dgvHours.AllowUserToDeleteRows = false;
            this.dgvHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHours.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.dgvHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHours.EnableHeadersVisualStyles = false;
            this.dgvHours.Location = new System.Drawing.Point(0, 60);
            this.dgvHours.MultiSelect = false;
            this.dgvHours.Name = "dgvHours";
            this.dgvHours.ReadOnly = true;
            this.dgvHours.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHours.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHours.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvHours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHours.Size = new System.Drawing.Size(1113, 613);
            this.dgvHours.TabIndex = 24;
            this.dgvHours.SelectionChanged += new System.EventHandler(this.dgvHours_SelectionChanged);
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
            this.btnDel.Location = new System.Drawing.Point(280, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(134, 45);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Delete Hour";
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
            this.btnSaveAlteration.Location = new System.Drawing.Point(140, 3);
            this.btnSaveAlteration.Name = "btnSaveAlteration";
            this.btnSaveAlteration.Size = new System.Drawing.Size(134, 45);
            this.btnSaveAlteration.TabIndex = 29;
            this.btnSaveAlteration.Text = "Save Hour";
            this.btnSaveAlteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaveAlteration.Click += new System.EventHandler(this.btnSaveAlteration_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewUser.BorderRadius = 3;
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnNewUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewUser.Location = new System.Drawing.Point(0, 3);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(134, 45);
            this.btnNewUser.TabIndex = 28;
            this.btnNewUser.Text = "New Hour";
            this.btnNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // txtDschour
            // 
            this.txtDschour.Location = new System.Drawing.Point(370, 24);
            this.txtDschour.Mask = "99:99h - 99:99h";
            this.txtDschour.Name = "txtDschour";
            this.txtDschour.Size = new System.Drawing.Size(177, 20);
            this.txtDschour.TabIndex = 28;
            // 
            // FrmHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 726);
            this.Controls.Add(this.dgvHours);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHours";
            this.Text = "FrmHours";
            this.Load += new System.EventHandler(this.FrmHours_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblstarts;
        private Guna.UI2.WinForms.Guna2TextBox txthourId;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvHours;
        private System.Windows.Forms.MaskedTextBox txtDschour;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnSaveAlteration;
        private Guna.UI2.WinForms.Guna2Button btnNewUser;
    }
}