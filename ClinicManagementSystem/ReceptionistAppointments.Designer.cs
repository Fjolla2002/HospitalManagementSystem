namespace ClinicManagementSystem
{
    partial class ReceptionistAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistAppointments));
            this.Logout = new System.Windows.Forms.Label();
            this.Doctors = new System.Windows.Forms.Label();
            this.AppointmentsDB = new System.Windows.Forms.DataGridView();
            this.AddAppointmentIcon = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Appointments = new System.Windows.Forms.Label();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.Patient = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.AddDoctors = new System.Windows.Forms.PictureBox();
            this.AddPatientIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentDatePicker = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DoctorName = new System.Windows.Forms.Label();
            this.DoctorNameTxtBox = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.Label();
            this.PatientNameTxtBox = new System.Windows.Forms.TextBox();
            this.DoctorIDPicker = new System.Windows.Forms.ComboBox();
            this.PatientIDPicker = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAppointmentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // AppointmentsDB
            // 
            this.AppointmentsDB.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentsDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDB.Location = new System.Drawing.Point(175, 236);
            this.AppointmentsDB.Name = "AppointmentsDB";
            this.AppointmentsDB.Size = new System.Drawing.Size(494, 158);
            this.AppointmentsDB.TabIndex = 36;
            this.AppointmentsDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDB_CellContentClick);
            // 
            // AddAppointmentIcon
            // 
            this.AddAppointmentIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.AddAppointmentIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddAppointmentIcon.BackgroundImage")));
            this.AddAppointmentIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddAppointmentIcon.Location = new System.Drawing.Point(10, 213);
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
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Green;
            this.AddButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(231, 192);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 29);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.EditButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(356, 192);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(108, 29);
            this.EditButton.TabIndex = 32;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(479, 192);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 29);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Appointments
            // 
            this.Appointments.AutoSize = true;
            this.Appointments.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Appointments.ForeColor = System.Drawing.Color.Black;
            this.Appointments.Location = new System.Drawing.Point(46, 226);
            this.Appointments.Name = "Appointments";
            this.Appointments.Size = new System.Drawing.Size(103, 17);
            this.Appointments.TabIndex = 14;
            this.Appointments.Text = "Appointments";
            this.Appointments.Click += new System.EventHandler(this.Appointments_Click);
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
            this.Title.Location = new System.Drawing.Point(352, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Appointments";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuPanel.Controls.Add(this.Appointments);
            this.MenuPanel.Controls.Add(this.AddAppointmentIcon);
            this.MenuPanel.Controls.Add(this.Dashboard);
            this.MenuPanel.Controls.Add(this.DashboardIcon);
            this.MenuPanel.Controls.Add(this.Logout);
            this.MenuPanel.Controls.Add(this.Doctors);
            this.MenuPanel.Controls.Add(this.Patient);
            this.MenuPanel.Controls.Add(this.LogoutIcon);
            this.MenuPanel.Controls.Add(this.AddDoctors);
            this.MenuPanel.Controls.Add(this.AddPatientIcon);
            this.MenuPanel.Controls.Add(this.Logo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(148, 430);
            this.MenuPanel.TabIndex = 0;
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
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Patient.ForeColor = System.Drawing.Color.Black;
            this.Patient.Location = new System.Drawing.Point(45, 150);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(63, 17);
            this.Patient.TabIndex = 8;
            this.Patient.Text = "Patients";
            this.Patient.Click += new System.EventHandler(this.Patient_Click);
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
            // AddPatientIcon
            // 
            this.AddPatientIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.AddPatientIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPatientIcon.BackgroundImage")));
            this.AddPatientIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPatientIcon.Location = new System.Drawing.Point(10, 139);
            this.AddPatientIcon.Name = "AddPatientIcon";
            this.AddPatientIcon.Size = new System.Drawing.Size(30, 30);
            this.AddPatientIcon.TabIndex = 5;
            this.AddPatientIcon.TabStop = false;
            this.AddPatientIcon.Click += new System.EventHandler(this.AddPatientIcon_Click);
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
            this.MainPanel.Controls.Add(this.timePicker);
            this.MainPanel.Controls.Add(this.AppointmentDatePicker);
            this.MainPanel.Controls.Add(this.dateTimePicker);
            this.MainPanel.Controls.Add(this.DoctorName);
            this.MainPanel.Controls.Add(this.DoctorNameTxtBox);
            this.MainPanel.Controls.Add(this.PatientName);
            this.MainPanel.Controls.Add(this.PatientNameTxtBox);
            this.MainPanel.Controls.Add(this.DoctorIDPicker);
            this.MainPanel.Controls.Add(this.PatientIDPicker);
            this.MainPanel.Controls.Add(this.AppointmentsDB);
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Controls.Add(this.EditButton);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.CloseIcon);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 430);
            this.MainPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(463, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Appointment Time";
            // 
            // timePicker
            // 
            this.timePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.timePicker.CustomFormat = "";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(465, 140);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(111, 20);
            this.timePicker.TabIndex = 45;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.AutoSize = true;
            this.AppointmentDatePicker.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.AppointmentDatePicker.ForeColor = System.Drawing.Color.SteelBlue;
            this.AppointmentDatePicker.Location = new System.Drawing.Point(463, 80);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(132, 17);
            this.AppointmentDatePicker.TabIndex = 44;
            this.AppointmentDatePicker.Text = "Appointment Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(465, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker.TabIndex = 43;
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSize = true;
            this.DoctorName.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.DoctorName.ForeColor = System.Drawing.Color.SteelBlue;
            this.DoctorName.Location = new System.Drawing.Point(308, 120);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(96, 17);
            this.DoctorName.TabIndex = 42;
            this.DoctorName.Text = "Doctor Name";
            // 
            // DoctorNameTxtBox
            // 
            this.DoctorNameTxtBox.Location = new System.Drawing.Point(311, 140);
            this.DoctorNameTxtBox.Name = "DoctorNameTxtBox";
            this.DoctorNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.DoctorNameTxtBox.TabIndex = 41;
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.PatientName.ForeColor = System.Drawing.Color.SteelBlue;
            this.PatientName.Location = new System.Drawing.Point(308, 80);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(100, 17);
            this.PatientName.TabIndex = 40;
            this.PatientName.Text = "Patient Name";
            // 
            // PatientNameTxtBox
            // 
            this.PatientNameTxtBox.Location = new System.Drawing.Point(311, 100);
            this.PatientNameTxtBox.Name = "PatientNameTxtBox";
            this.PatientNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.PatientNameTxtBox.TabIndex = 39;
            // 
            // DoctorIDPicker
            // 
            this.DoctorIDPicker.FormattingEnabled = true;
            this.DoctorIDPicker.Location = new System.Drawing.Point(165, 139);
            this.DoctorIDPicker.Name = "DoctorIDPicker";
            this.DoctorIDPicker.Size = new System.Drawing.Size(121, 21);
            this.DoctorIDPicker.TabIndex = 38;
            this.DoctorIDPicker.Text = "Doctor ID";
            this.DoctorIDPicker.SelectionChangeCommitted += new System.EventHandler(this.DoctorIDPicker_SelectionChangeCommitted);
            // 
            // PatientIDPicker
            // 
            this.PatientIDPicker.FormattingEnabled = true;
            this.PatientIDPicker.Location = new System.Drawing.Point(165, 99);
            this.PatientIDPicker.Name = "PatientIDPicker";
            this.PatientIDPicker.Size = new System.Drawing.Size(121, 21);
            this.PatientIDPicker.TabIndex = 37;
            this.PatientIDPicker.Text = "Patient ID";
            this.PatientIDPicker.SelectionChangeCommitted += new System.EventHandler(this.PatientIDPicker_SelectionChangeCommitted);
            // 
            // ReceptionistAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionistAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionistAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAppointmentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Doctors;
        private System.Windows.Forms.DataGridView AppointmentsDB;
        private System.Windows.Forms.PictureBox AddAppointmentIcon;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Appointments;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.PictureBox AddDoctors;
        private System.Windows.Forms.PictureBox AddPatientIcon;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox DoctorIDPicker;
        private System.Windows.Forms.ComboBox PatientIDPicker;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.TextBox PatientNameTxtBox;
        private System.Windows.Forms.Label DoctorName;
        private System.Windows.Forms.TextBox DoctorNameTxtBox;
        private System.Windows.Forms.Label AppointmentDatePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}