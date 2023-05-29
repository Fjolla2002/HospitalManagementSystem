namespace ClinicManagementSystem
{
    partial class DoctorsAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsAppointments));
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Prescriptions = new System.Windows.Forms.Label();
            this.AddPrescriptionIcon = new System.Windows.Forms.PictureBox();
            this.Appointments = new System.Windows.Forms.Label();
            this.AddAppointmentIcon = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.Label();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentsDB = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPrescriptionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAppointmentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.Title.Location = new System.Drawing.Point(349, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Appointments";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuPanel.Controls.Add(this.Prescriptions);
            this.MenuPanel.Controls.Add(this.AddPrescriptionIcon);
            this.MenuPanel.Controls.Add(this.Appointments);
            this.MenuPanel.Controls.Add(this.AddAppointmentIcon);
            this.MenuPanel.Controls.Add(this.Dashboard);
            this.MenuPanel.Controls.Add(this.DashboardIcon);
            this.MenuPanel.Controls.Add(this.Logout);
            this.MenuPanel.Controls.Add(this.LogoutIcon);
            this.MenuPanel.Controls.Add(this.Logo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(148, 430);
            this.MenuPanel.TabIndex = 0;
            // 
            // Prescriptions
            // 
            this.Prescriptions.AutoSize = true;
            this.Prescriptions.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Prescriptions.ForeColor = System.Drawing.Color.Black;
            this.Prescriptions.Location = new System.Drawing.Point(45, 200);
            this.Prescriptions.Name = "Prescriptions";
            this.Prescriptions.Size = new System.Drawing.Size(97, 17);
            this.Prescriptions.TabIndex = 18;
            this.Prescriptions.Text = "Prescriptions";
            this.Prescriptions.Click += new System.EventHandler(this.Prescriptions_Click);
            // 
            // AddPrescriptionIcon
            // 
            this.AddPrescriptionIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.AddPrescriptionIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPrescriptionIcon.BackgroundImage")));
            this.AddPrescriptionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPrescriptionIcon.Location = new System.Drawing.Point(10, 187);
            this.AddPrescriptionIcon.Name = "AddPrescriptionIcon";
            this.AddPrescriptionIcon.Size = new System.Drawing.Size(30, 30);
            this.AddPrescriptionIcon.TabIndex = 17;
            this.AddPrescriptionIcon.TabStop = false;
            this.AddPrescriptionIcon.Click += new System.EventHandler(this.AddPrescriptionIcon_Click);
            // 
            // Appointments
            // 
            this.Appointments.AutoSize = true;
            this.Appointments.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Appointments.ForeColor = System.Drawing.Color.Black;
            this.Appointments.Location = new System.Drawing.Point(45, 155);
            this.Appointments.Name = "Appointments";
            this.Appointments.Size = new System.Drawing.Size(103, 17);
            this.Appointments.TabIndex = 14;
            this.Appointments.Text = "Appointments";
            this.Appointments.Click += new System.EventHandler(this.Appointments_Click);
            // 
            // AddAppointmentIcon
            // 
            this.AddAppointmentIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.AddAppointmentIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddAppointmentIcon.BackgroundImage")));
            this.AddAppointmentIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddAppointmentIcon.Location = new System.Drawing.Point(10, 142);
            this.AddAppointmentIcon.Name = "AddAppointmentIcon";
            this.AddAppointmentIcon.Size = new System.Drawing.Size(30, 30);
            this.AddAppointmentIcon.TabIndex = 13;
            this.AddAppointmentIcon.TabStop = false;
            this.AddAppointmentIcon.Click += new System.EventHandler(this.AddAppointmentIcon_Click);
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
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
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
            this.LogoutIcon.Click += new System.EventHandler(this.LogoutIcon_Click);
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.AppointmentsDB);
            this.MainPanel.Controls.Add(this.CloseIcon);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 430);
            this.MainPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(186, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "List of Appointments:";
            // 
            // AppointmentsDB
            // 
            this.AppointmentsDB.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentsDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDB.Location = new System.Drawing.Point(180, 132);
            this.AppointmentsDB.Name = "AppointmentsDB";
            this.AppointmentsDB.Size = new System.Drawing.Size(494, 262);
            this.AppointmentsDB.TabIndex = 38;
            // 
            // DoctorsAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPrescriptionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAppointmentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label Appointments;
        private System.Windows.Forms.PictureBox AddAppointmentIcon;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AppointmentsDB;
        private System.Windows.Forms.Label Prescriptions;
        private System.Windows.Forms.PictureBox AddPrescriptionIcon;
    }
}