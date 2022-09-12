namespace Academy
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pbLed = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblAcess = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.PMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.SubMain = new System.Windows.Forms.Panel();
            this.btnClass = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeachersManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnHour = new Guna.UI2.WinForms.Guna2Button();
            this.btnDataBase = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.SubUsers = new System.Windows.Forms.Panel();
            this.btnUserManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.SubLearner = new System.Windows.Forms.Panel();
            this.btnLearnersManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewLearner = new Guna.UI2.WinForms.Guna2Button();
            this.btnLearner = new Guna.UI2.WinForms.Guna2Button();
            this.pbLog = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLed)).BeginInit();
            this.panelTop.SuspendLayout();
            this.PMenu.SuspendLayout();
            this.SubMain.SuspendLayout();
            this.SubUsers.SuspendLayout();
            this.SubLearner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Maroon;
            this.panelBottom.Controls.Add(this.pbLed);
            this.panelBottom.Controls.Add(this.lblUsuario);
            this.panelBottom.Controls.Add(this.lblAcesso);
            this.panelBottom.Controls.Add(this.lblUs);
            this.panelBottom.Controls.Add(this.lblAcess);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 753);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1169, 35);
            this.panelBottom.TabIndex = 2;
            // 
            // pbLed
            // 
            this.pbLed.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLed.FillColor = System.Drawing.Color.Transparent;
            this.pbLed.Image = global::Academy.Properties.Resources.check;
            this.pbLed.ImageRotate = 0F;
            this.pbLed.Location = new System.Drawing.Point(0, 0);
            this.pbLed.Name = "pbLed";
            this.pbLed.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbLed.Size = new System.Drawing.Size(47, 35);
            this.pbLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLed.TabIndex = 3;
            this.pbLed.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(221, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(29, 21);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = ":---";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcesso.Location = new System.Drawing.Point(119, 5);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(27, 21);
            this.lblAcesso.TabIndex = 2;
            this.lblAcesso.Text = ": 0";
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUs.Location = new System.Drawing.Point(162, 5);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(46, 21);
            this.lblUs.TabIndex = 1;
            this.lblUs.Text = "User:";
            // 
            // lblAcess
            // 
            this.lblAcess.AutoSize = true;
            this.lblAcess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcess.Location = new System.Drawing.Point(54, 5);
            this.lblAcess.Name = "lblAcess";
            this.lblAcess.Size = new System.Drawing.Size(59, 21);
            this.lblAcess.TabIndex = 0;
            this.lblAcess.Text = "Acess:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Maroon;
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1169, 35);
            this.panelTop.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.BorderRadius = 5;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 35);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(1046, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 35);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMax.BackgroundImage")));
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(1087, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(41, 35);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1128, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PMenu
            // 
            this.PMenu.AutoScroll = true;
            this.PMenu.BackColor = System.Drawing.Color.Maroon;
            this.PMenu.Controls.Add(this.btnLogout);
            this.PMenu.Controls.Add(this.SubMain);
            this.PMenu.Controls.Add(this.btnMaintenance);
            this.PMenu.Controls.Add(this.SubUsers);
            this.PMenu.Controls.Add(this.btnUsers);
            this.PMenu.Controls.Add(this.SubLearner);
            this.PMenu.Controls.Add(this.btnLearner);
            this.PMenu.Controls.Add(this.pbLog);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.Location = new System.Drawing.Point(0, 35);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(267, 718);
            this.PMenu.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(0, 769);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SubMain
            // 
            this.SubMain.BackColor = System.Drawing.Color.Brown;
            this.SubMain.Controls.Add(this.btnClass);
            this.SubMain.Controls.Add(this.btnTeachersManager);
            this.SubMain.Controls.Add(this.btnHour);
            this.SubMain.Controls.Add(this.btnDataBase);
            this.SubMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMain.Location = new System.Drawing.Point(0, 589);
            this.SubMain.Name = "SubMain";
            this.SubMain.Size = new System.Drawing.Size(250, 180);
            this.SubMain.TabIndex = 34;
            // 
            // btnClass
            // 
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FillColor = System.Drawing.Color.Transparent;
            this.btnClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Location = new System.Drawing.Point(0, 135);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(250, 45);
            this.btnClass.TabIndex = 32;
            this.btnClass.Text = "Classes";
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTeachersManager
            // 
            this.btnTeachersManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachersManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTeachersManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTeachersManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTeachersManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTeachersManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachersManager.FillColor = System.Drawing.Color.Transparent;
            this.btnTeachersManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachersManager.ForeColor = System.Drawing.Color.White;
            this.btnTeachersManager.Location = new System.Drawing.Point(0, 90);
            this.btnTeachersManager.Name = "btnTeachersManager";
            this.btnTeachersManager.Size = new System.Drawing.Size(250, 45);
            this.btnTeachersManager.TabIndex = 31;
            this.btnTeachersManager.Text = "Teachers";
            this.btnTeachersManager.Click += new System.EventHandler(this.btnTeachersManager_Click);
            // 
            // btnHour
            // 
            this.btnHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHour.FillColor = System.Drawing.Color.Transparent;
            this.btnHour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHour.ForeColor = System.Drawing.Color.White;
            this.btnHour.Location = new System.Drawing.Point(0, 45);
            this.btnHour.Name = "btnHour";
            this.btnHour.Size = new System.Drawing.Size(250, 45);
            this.btnHour.TabIndex = 30;
            this.btnHour.Text = "Hours";
            this.btnHour.Click += new System.EventHandler(this.btnHour_Click);
            // 
            // btnDataBase
            // 
            this.btnDataBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataBase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDataBase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDataBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDataBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataBase.FillColor = System.Drawing.Color.Transparent;
            this.btnDataBase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataBase.ForeColor = System.Drawing.Color.White;
            this.btnDataBase.Location = new System.Drawing.Point(0, 0);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(250, 45);
            this.btnDataBase.TabIndex = 29;
            this.btnDataBase.Text = "DataBase";
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FillColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 544);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(250, 45);
            this.btnMaintenance.TabIndex = 16;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // SubUsers
            // 
            this.SubUsers.BackColor = System.Drawing.Color.Brown;
            this.SubUsers.Controls.Add(this.btnUserManager);
            this.SubUsers.Controls.Add(this.btnNewUser);
            this.SubUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubUsers.Location = new System.Drawing.Point(0, 424);
            this.SubUsers.Name = "SubUsers";
            this.SubUsers.Size = new System.Drawing.Size(250, 120);
            this.SubUsers.TabIndex = 25;
            // 
            // btnUserManager
            // 
            this.btnUserManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManager.FillColor = System.Drawing.Color.Transparent;
            this.btnUserManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManager.ForeColor = System.Drawing.Color.White;
            this.btnUserManager.Location = new System.Drawing.Point(0, 45);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(250, 45);
            this.btnUserManager.TabIndex = 28;
            this.btnUserManager.Text = "Users Mananger";
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnNewUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(0, 0);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(250, 45);
            this.btnNewUser.TabIndex = 27;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.Location = new System.Drawing.Point(0, 379);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(250, 45);
            this.btnUsers.TabIndex = 15;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // SubLearner
            // 
            this.SubLearner.BackColor = System.Drawing.Color.Brown;
            this.SubLearner.Controls.Add(this.btnLearnersManager);
            this.SubLearner.Controls.Add(this.btnNewLearner);
            this.SubLearner.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubLearner.Location = new System.Drawing.Point(0, 259);
            this.SubLearner.Name = "SubLearner";
            this.SubLearner.Size = new System.Drawing.Size(250, 120);
            this.SubLearner.TabIndex = 15;
            // 
            // btnLearnersManager
            // 
            this.btnLearnersManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearnersManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLearnersManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLearnersManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLearnersManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLearnersManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLearnersManager.FillColor = System.Drawing.Color.Transparent;
            this.btnLearnersManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearnersManager.ForeColor = System.Drawing.Color.White;
            this.btnLearnersManager.Location = new System.Drawing.Point(0, 45);
            this.btnLearnersManager.Name = "btnLearnersManager";
            this.btnLearnersManager.Size = new System.Drawing.Size(250, 45);
            this.btnLearnersManager.TabIndex = 27;
            this.btnLearnersManager.Text = "Learners Manager";
            this.btnLearnersManager.Click += new System.EventHandler(this.btnLearnersManager_Click);
            // 
            // btnNewLearner
            // 
            this.btnNewLearner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLearner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewLearner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewLearner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewLearner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewLearner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewLearner.FillColor = System.Drawing.Color.Transparent;
            this.btnNewLearner.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLearner.ForeColor = System.Drawing.Color.White;
            this.btnNewLearner.Location = new System.Drawing.Point(0, 0);
            this.btnNewLearner.Name = "btnNewLearner";
            this.btnNewLearner.Size = new System.Drawing.Size(250, 45);
            this.btnNewLearner.TabIndex = 26;
            this.btnNewLearner.Text = "New Learner";
            this.btnNewLearner.Click += new System.EventHandler(this.btnNewLearner_Click);
            // 
            // btnLearner
            // 
            this.btnLearner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLearner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLearner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLearner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLearner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLearner.FillColor = System.Drawing.Color.Transparent;
            this.btnLearner.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearner.ForeColor = System.Drawing.Color.White;
            this.btnLearner.Location = new System.Drawing.Point(0, 214);
            this.btnLearner.Name = "btnLearner";
            this.btnLearner.Size = new System.Drawing.Size(250, 45);
            this.btnLearner.TabIndex = 14;
            this.btnLearner.Text = "Learners";
            this.btnLearner.Click += new System.EventHandler(this.btnLearner_Click);
            // 
            // pbLog
            // 
            this.pbLog.BackColor = System.Drawing.Color.Transparent;
            this.pbLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLog.FillColor = System.Drawing.Color.Transparent;
            this.pbLog.Image = ((System.Drawing.Image)(resources.GetObject("pbLog.Image")));
            this.pbLog.ImageRotate = 0F;
            this.pbLog.Location = new System.Drawing.Point(0, 0);
            this.pbLog.Name = "pbLog";
            this.pbLog.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbLog.Size = new System.Drawing.Size(250, 214);
            this.pbLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLog.TabIndex = 0;
            this.pbLog.TabStop = false;
            this.pbLog.UseTransparentBackground = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(267, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(902, 718);
            this.MainPanel.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 788);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academy Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLed)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.PMenu.ResumeLayout(false);
            this.SubMain.ResumeLayout(false);
            this.SubUsers.ResumeLayout(false);
            this.SubLearner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblAcess;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbLed;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel PMenu;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnLearner;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLog;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Panel SubMain;
        private Guna.UI2.WinForms.Guna2Button btnDataBase;
        private Guna.UI2.WinForms.Guna2Button btnMaintenance;
        private System.Windows.Forms.Panel SubUsers;
        private Guna.UI2.WinForms.Guna2Button btnUserManager;
        private Guna.UI2.WinForms.Guna2Button btnNewUser;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private System.Windows.Forms.Panel SubLearner;
        private Guna.UI2.WinForms.Guna2Button btnNewLearner;
        private Guna.UI2.WinForms.Guna2Button btnHour;
        private Guna.UI2.WinForms.Guna2Button btnTeachersManager;
        public System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button btnClass;
        private Guna.UI2.WinForms.Guna2Button btnLearnersManager;
    }
}

