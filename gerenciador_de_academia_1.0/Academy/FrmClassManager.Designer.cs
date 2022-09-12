namespace Academy
{
    partial class FrmClassManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassManager));
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.btnDelClass = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveAlteration = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewClass = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtRest = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.txtClassName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.cmbHour = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.nUpMaxLearners = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblteacher = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnImpressClass = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpMaxLearners)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvClass.EnableHeadersVisualStyles = false;
            this.dgvClass.Location = new System.Drawing.Point(0, 0);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClass.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(452, 756);
            this.dgvClass.TabIndex = 30;
            this.dgvClass.SelectionChanged += new System.EventHandler(this.dgvClass_SelectionChanged);
            // 
            // btnDelClass
            // 
            this.btnDelClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelClass.BorderRadius = 3;
            this.btnDelClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnDelClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelClass.ForeColor = System.Drawing.Color.White;
            this.btnDelClass.Location = new System.Drawing.Point(328, 3);
            this.btnDelClass.Name = "btnDelClass";
            this.btnDelClass.Size = new System.Drawing.Size(158, 45);
            this.btnDelClass.TabIndex = 8;
            this.btnDelClass.Text = "Delete Class";
            this.btnDelClass.Click += new System.EventHandler(this.btnDelClass_Click);
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
            this.btnSaveAlteration.TabIndex = 7;
            this.btnSaveAlteration.Text = "Save Editions";
            this.btnSaveAlteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaveAlteration.Click += new System.EventHandler(this.btnSaveAlteration_Click);
            // 
            // btnNewClass
            // 
            this.btnNewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewClass.BorderRadius = 3;
            this.btnNewClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnNewClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClass.ForeColor = System.Drawing.Color.White;
            this.btnNewClass.Image = ((System.Drawing.Image)(resources.GetObject("btnNewClass.Image")));
            this.btnNewClass.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewClass.Location = new System.Drawing.Point(0, 3);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(158, 45);
            this.btnNewClass.TabIndex = 6;
            this.btnNewClass.Text = "New Class";
            this.btnNewClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtRest);
            this.panelTop.Controls.Add(this.lblRest);
            this.panelTop.Controls.Add(this.txtClassName);
            this.panelTop.Controls.Add(this.lblClassName);
            this.panelTop.Controls.Add(this.cmbHour);
            this.panelTop.Controls.Add(this.lblHour);
            this.panelTop.Controls.Add(this.lblMax);
            this.panelTop.Controls.Add(this.nUpMaxLearners);
            this.panelTop.Controls.Add(this.cmbStatus);
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Controls.Add(this.cmbTeacher);
            this.panelTop.Controls.Add(this.lblteacher);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTop.Location = new System.Drawing.Point(458, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(465, 756);
            this.panelTop.TabIndex = 28;
            // 
            // txtRest
            // 
            this.txtRest.BorderRadius = 5;
            this.txtRest.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRest.DefaultText = "";
            this.txtRest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRest.Location = new System.Drawing.Point(7, 357);
            this.txtRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRest.Name = "txtRest";
            this.txtRest.PasswordChar = '\0';
            this.txtRest.PlaceholderText = "";
            this.txtRest.ReadOnly = true;
            this.txtRest.SelectedText = "";
            this.txtRest.Size = new System.Drawing.Size(205, 36);
            this.txtRest.TabIndex = 38;
            this.txtRest.TabStop = false;
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.BackColor = System.Drawing.Color.Transparent;
            this.lblRest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.ForeColor = System.Drawing.Color.Black;
            this.lblRest.Location = new System.Drawing.Point(3, 334);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(39, 20);
            this.lblRest.TabIndex = 39;
            this.lblRest.Text = "Rest";
            // 
            // txtClassName
            // 
            this.txtClassName.BorderRadius = 5;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.DefaultText = "";
            this.txtClassName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClassName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClassName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClassName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClassName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClassName.Location = new System.Drawing.Point(7, 32);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.PlaceholderText = "";
            this.txtClassName.SelectedText = "";
            this.txtClassName.Size = new System.Drawing.Size(425, 36);
            this.txtClassName.TabIndex = 1;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(3, 9);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(94, 20);
            this.lblClassName.TabIndex = 37;
            this.lblClassName.Text = "Class Name";
            // 
            // cmbHour
            // 
            this.cmbHour.BackColor = System.Drawing.Color.Transparent;
            this.cmbHour.BorderRadius = 5;
            this.cmbHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbHour.ItemHeight = 30;
            this.cmbHour.Location = new System.Drawing.Point(7, 284);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(425, 36);
            this.cmbHour.TabIndex = 5;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.Transparent;
            this.lblHour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Black;
            this.lblHour.Location = new System.Drawing.Point(3, 249);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 20);
            this.lblHour.TabIndex = 36;
            this.lblHour.Text = "Hour";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.Black;
            this.lblMax.Location = new System.Drawing.Point(3, 165);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(107, 20);
            this.lblMax.TabIndex = 35;
            this.lblMax.Text = "Max Learners";
            // 
            // nUpMaxLearners
            // 
            this.nUpMaxLearners.BackColor = System.Drawing.Color.Transparent;
            this.nUpMaxLearners.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nUpMaxLearners.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nUpMaxLearners.ForeColor = System.Drawing.Color.Black;
            this.nUpMaxLearners.Location = new System.Drawing.Point(7, 198);
            this.nUpMaxLearners.Name = "nUpMaxLearners";
            this.nUpMaxLearners.Size = new System.Drawing.Size(205, 36);
            this.nUpMaxLearners.TabIndex = 3;
            this.nUpMaxLearners.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.nUpMaxLearners.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nUpMaxLearners.ValueChanged += new System.EventHandler(this.nUpMaxLearners_ValueChanged);
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
            this.cmbStatus.Location = new System.Drawing.Point(218, 198);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(214, 36);
            this.cmbStatus.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(214, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Status";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cmbTeacher.BorderRadius = 5;
            this.cmbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTeacher.ItemHeight = 30;
            this.cmbTeacher.Location = new System.Drawing.Point(7, 117);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(425, 36);
            this.cmbTeacher.TabIndex = 2;
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.BackColor = System.Drawing.Color.Transparent;
            this.lblteacher.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.ForeColor = System.Drawing.Color.Black;
            this.lblteacher.Location = new System.Drawing.Point(3, 84);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(68, 20);
            this.lblteacher.TabIndex = 25;
            this.lblteacher.Text = "Teacher";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnImpressClass);
            this.panelBottom.Controls.Add(this.btnDelClass);
            this.panelBottom.Controls.Add(this.btnSaveAlteration);
            this.panelBottom.Controls.Add(this.btnNewClass);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 756);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(923, 53);
            this.panelBottom.TabIndex = 29;
            // 
            // btnImpressClass
            // 
            this.btnImpressClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImpressClass.BorderRadius = 3;
            this.btnImpressClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpressClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImpressClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImpressClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImpressClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImpressClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnImpressClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpressClass.ForeColor = System.Drawing.Color.White;
            this.btnImpressClass.Location = new System.Drawing.Point(492, 3);
            this.btnImpressClass.Name = "btnImpressClass";
            this.btnImpressClass.Size = new System.Drawing.Size(158, 45);
            this.btnImpressClass.TabIndex = 9;
            this.btnImpressClass.Text = "Impress Class";
            this.btnImpressClass.Click += new System.EventHandler(this.btnImpressClass_Click);
            // 
            // FrmClassManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 809);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClassManager";
            this.Text = "FrmClassManager";
            this.Load += new System.EventHandler(this.FrmClassManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpMaxLearners)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClass;
        private Guna.UI2.WinForms.Guna2Button btnDelClass;
        private Guna.UI2.WinForms.Guna2Button btnSaveAlteration;
        private Guna.UI2.WinForms.Guna2Button btnNewClass;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMax;
        private Guna.UI2.WinForms.Guna2NumericUpDown nUpMaxLearners;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTeacher;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnImpressClass;
        private Guna.UI2.WinForms.Guna2TextBox txtClassName;
        private System.Windows.Forms.Label lblClassName;
        private Guna.UI2.WinForms.Guna2TextBox txtRest;
        private System.Windows.Forms.Label lblRest;
    }
}