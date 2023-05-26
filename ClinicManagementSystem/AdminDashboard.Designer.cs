namespace ClinicManagementSystem
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.DoctorsPanel = new System.Windows.Forms.Panel();
            this.TotalDoctorsNr = new System.Windows.Forms.Label();
            this.TotalDoctors = new System.Windows.Forms.Label();
            this.DoctorIcon = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Label();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.Doctors = new System.Windows.Forms.Label();
            this.Receptionists = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.AddDoctors = new System.Windows.Forms.PictureBox();
            this.AddReceptionistIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.TotalReceptionists = new System.Windows.Forms.Label();
            this.ReceptionistsPanel = new System.Windows.Forms.Panel();
            this.TotalReceptionistsNr = new System.Windows.Forms.Label();
            this.ReceptionIcon = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DoctorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.ReceptionistsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorsPanel
            // 
            this.DoctorsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DoctorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorsPanel.Controls.Add(this.TotalDoctorsNr);
            this.DoctorsPanel.Controls.Add(this.TotalDoctors);
            this.DoctorsPanel.Controls.Add(this.DoctorIcon);
            this.DoctorsPanel.Location = new System.Drawing.Point(433, 114);
            this.DoctorsPanel.Name = "DoctorsPanel";
            this.DoctorsPanel.Size = new System.Drawing.Size(152, 83);
            this.DoctorsPanel.TabIndex = 5;
            // 
            // TotalDoctorsNr
            // 
            this.TotalDoctorsNr.AutoSize = true;
            this.TotalDoctorsNr.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold);
            this.TotalDoctorsNr.ForeColor = System.Drawing.Color.Blue;
            this.TotalDoctorsNr.Location = new System.Drawing.Point(79, 48);
            this.TotalDoctorsNr.Name = "TotalDoctorsNr";
            this.TotalDoctorsNr.Size = new System.Drawing.Size(32, 22);
            this.TotalDoctorsNr.TabIndex = 8;
            this.TotalDoctorsNr.Text = "Nr";
            // 
            // TotalDoctors
            // 
            this.TotalDoctors.AutoSize = true;
            this.TotalDoctors.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.TotalDoctors.ForeColor = System.Drawing.Color.SteelBlue;
            this.TotalDoctors.Location = new System.Drawing.Point(11, 13);
            this.TotalDoctors.Name = "TotalDoctors";
            this.TotalDoctors.Size = new System.Drawing.Size(96, 17);
            this.TotalDoctors.TabIndex = 7;
            this.TotalDoctors.Text = "Total Doctors";
            // 
            // DoctorIcon
            // 
            this.DoctorIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DoctorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoctorIcon.BackgroundImage")));
            this.DoctorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoctorIcon.Location = new System.Drawing.Point(11, 33);
            this.DoctorIcon.Name = "DoctorIcon";
            this.DoctorIcon.Size = new System.Drawing.Size(39, 39);
            this.DoctorIcon.TabIndex = 4;
            this.DoctorIcon.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuPanel.Controls.Add(this.Dashboard);
            this.MenuPanel.Controls.Add(this.DashboardIcon);
            this.MenuPanel.Controls.Add(this.Logout);
            this.MenuPanel.Controls.Add(this.Doctors);
            this.MenuPanel.Controls.Add(this.Receptionists);
            this.MenuPanel.Controls.Add(this.LogoutIcon);
            this.MenuPanel.Controls.Add(this.AddDoctors);
            this.MenuPanel.Controls.Add(this.AddReceptionistIcon);
            this.MenuPanel.Controls.Add(this.Logo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(148, 430);
            this.MenuPanel.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Dashboard.ForeColor = System.Drawing.Color.Black;
            this.Dashboard.Location = new System.Drawing.Point(45, 114);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(82, 17);
            this.Dashboard.TabIndex = 12;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // DashboardIcon
            // 
            this.DashboardIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.DashboardIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashboardIcon.BackgroundImage")));
            this.DashboardIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardIcon.Location = new System.Drawing.Point(10, 99);
            this.DashboardIcon.Name = "DashboardIcon";
            this.DashboardIcon.Size = new System.Drawing.Size(30, 30);
            this.DashboardIcon.TabIndex = 11;
            this.DashboardIcon.TabStop = false;
            this.DashboardIcon.Click += new System.EventHandler(this.DashboardIcon_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(45, 405);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(54, 17);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "Logout";
            // 
            // Doctors
            // 
            this.Doctors.AutoSize = true;
            this.Doctors.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Doctors.ForeColor = System.Drawing.Color.Black;
            this.Doctors.Location = new System.Drawing.Point(45, 192);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(59, 17);
            this.Doctors.TabIndex = 9;
            this.Doctors.Text = "Doctors";
            this.Doctors.Click += new System.EventHandler(this.Doctors_Click);
            // 
            // Receptionists
            // 
            this.Receptionists.AutoSize = true;
            this.Receptionists.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Receptionists.ForeColor = System.Drawing.Color.Black;
            this.Receptionists.Location = new System.Drawing.Point(45, 150);
            this.Receptionists.Name = "Receptionists";
            this.Receptionists.Size = new System.Drawing.Size(99, 17);
            this.Receptionists.TabIndex = 8;
            this.Receptionists.Text = "Receptionists";
            this.Receptionists.Click += new System.EventHandler(this.Receptionists_Click);
            // 
            // LogoutIcon
            // 
            this.LogoutIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.LogoutIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutIcon.BackgroundImage")));
            this.LogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutIcon.Location = new System.Drawing.Point(10, 389);
            this.LogoutIcon.Name = "LogoutIcon";
            this.LogoutIcon.Size = new System.Drawing.Size(30, 30);
            this.LogoutIcon.TabIndex = 7;
            this.LogoutIcon.TabStop = false;
            // 
            // AddDoctors
            // 
            this.AddDoctors.BackColor = System.Drawing.Color.SteelBlue;
            this.AddDoctors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddDoctors.BackgroundImage")));
            this.AddDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDoctors.Location = new System.Drawing.Point(10, 177);
            this.AddDoctors.Name = "AddDoctors";
            this.AddDoctors.Size = new System.Drawing.Size(30, 30);
            this.AddDoctors.TabIndex = 6;
            this.AddDoctors.TabStop = false;
            this.AddDoctors.Click += new System.EventHandler(this.AddDoctors_Click);
            // 
            // AddReceptionistIcon
            // 
            this.AddReceptionistIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.AddReceptionistIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddReceptionistIcon.BackgroundImage")));
            this.AddReceptionistIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddReceptionistIcon.Location = new System.Drawing.Point(10, 139);
            this.AddReceptionistIcon.Name = "AddReceptionistIcon";
            this.AddReceptionistIcon.Size = new System.Drawing.Size(30, 30);
            this.AddReceptionistIcon.TabIndex = 5;
            this.AddReceptionistIcon.TabStop = false;
            this.AddReceptionistIcon.Click += new System.EventHandler(this.AddReceptionistIcon_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(37, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(53, 43);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // CloseIcon
            // 
            this.CloseIcon.BackColor = System.Drawing.SystemColors.Control;
            this.CloseIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseIcon.BackgroundImage")));
            this.CloseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseIcon.Location = new System.Drawing.Point(680, 3);
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(26, 26);
            this.CloseIcon.TabIndex = 3;
            this.CloseIcon.TabStop = false;
            this.CloseIcon.Click += new System.EventHandler(this.CloseIcon_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.SteelBlue;
            this.Title.Location = new System.Drawing.Point(285, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(278, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Hospital Management System";
            // 
            // TotalReceptionists
            // 
            this.TotalReceptionists.AutoSize = true;
            this.TotalReceptionists.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.TotalReceptionists.ForeColor = System.Drawing.Color.SteelBlue;
            this.TotalReceptionists.Location = new System.Drawing.Point(8, 13);
            this.TotalReceptionists.Name = "TotalReceptionists";
            this.TotalReceptionists.Size = new System.Drawing.Size(136, 17);
            this.TotalReceptionists.TabIndex = 6;
            this.TotalReceptionists.Text = "Total Receptionsits";
            // 
            // ReceptionistsPanel
            // 
            this.ReceptionistsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReceptionistsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceptionistsPanel.Controls.Add(this.TotalReceptionistsNr);
            this.ReceptionistsPanel.Controls.Add(this.TotalReceptionists);
            this.ReceptionistsPanel.Controls.Add(this.ReceptionIcon);
            this.ReceptionistsPanel.Location = new System.Drawing.Point(228, 114);
            this.ReceptionistsPanel.Name = "ReceptionistsPanel";
            this.ReceptionistsPanel.Size = new System.Drawing.Size(159, 83);
            this.ReceptionistsPanel.TabIndex = 4;
            // 
            // TotalReceptionistsNr
            // 
            this.TotalReceptionistsNr.AutoSize = true;
            this.TotalReceptionistsNr.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold);
            this.TotalReceptionistsNr.ForeColor = System.Drawing.Color.Blue;
            this.TotalReceptionistsNr.Location = new System.Drawing.Point(72, 48);
            this.TotalReceptionistsNr.Name = "TotalReceptionistsNr";
            this.TotalReceptionistsNr.Size = new System.Drawing.Size(32, 22);
            this.TotalReceptionistsNr.TabIndex = 7;
            this.TotalReceptionistsNr.Text = "Nr";
            // 
            // ReceptionIcon
            // 
            this.ReceptionIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReceptionIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReceptionIcon.BackgroundImage")));
            this.ReceptionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReceptionIcon.Location = new System.Drawing.Point(11, 33);
            this.ReceptionIcon.Name = "ReceptionIcon";
            this.ReceptionIcon.Size = new System.Drawing.Size(39, 39);
            this.ReceptionIcon.TabIndex = 4;
            this.ReceptionIcon.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.DoctorsPanel);
            this.MainPanel.Controls.Add(this.ReceptionistsPanel);
            this.MainPanel.Controls.Add(this.CloseIcon);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 430);
            this.MainPanel.TabIndex = 4;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.DoctorsPanel.ResumeLayout(false);
            this.DoctorsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.ReceptionistsPanel.ResumeLayout(false);
            this.ReceptionistsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DoctorsPanel;
        private System.Windows.Forms.Label TotalDoctorsNr;
        private System.Windows.Forms.Label TotalDoctors;
        private System.Windows.Forms.PictureBox DoctorIcon;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Doctors;
        private System.Windows.Forms.Label Receptionists;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.PictureBox AddDoctors;
        private System.Windows.Forms.PictureBox AddReceptionistIcon;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TotalReceptionists;
        private System.Windows.Forms.Panel ReceptionistsPanel;
        private System.Windows.Forms.Label TotalReceptionistsNr;
        private System.Windows.Forms.PictureBox ReceptionIcon;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel MainPanel;
    }
}