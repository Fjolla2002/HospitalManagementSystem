namespace ClinicManagementSystem
{
    partial class ReceptionistPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistPatients));
            this.AddDoctors = new System.Windows.Forms.PictureBox();
            this.AddPatientIcon = new System.Windows.Forms.PictureBox();
            this.PatientsDB = new System.Windows.Forms.DataGridView();
            this.Patient = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.EmailtxtBox = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.PhoneNoTxtBox = new System.Windows.Forms.TextBox();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.Address = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderPicker = new System.Windows.Forms.ComboBox();
            this.PatientName = new System.Windows.Forms.Label();
            this.PatientNameTxtBox = new System.Windows.Forms.TextBox();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Appointments = new System.Windows.Forms.Label();
            this.AddAppointmentIcon = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.Doctors = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddAppointmentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // PatientsDB
            // 
            this.PatientsDB.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDB.Location = new System.Drawing.Point(175, 236);
            this.PatientsDB.Name = "PatientsDB";
            this.PatientsDB.Size = new System.Drawing.Size(494, 158);
            this.PatientsDB.TabIndex = 36;
            this.PatientsDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDB_CellContentClick);
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
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.Color.SteelBlue;
            this.Email.Location = new System.Drawing.Point(526, 89);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 17);
            this.Email.TabIndex = 30;
            this.Email.Text = "Email";
            // 
            // EmailtxtBox
            // 
            this.EmailtxtBox.Location = new System.Drawing.Point(526, 106);
            this.EmailtxtBox.Name = "EmailtxtBox";
            this.EmailtxtBox.Size = new System.Drawing.Size(122, 20);
            this.EmailtxtBox.TabIndex = 29;
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.PhoneNo.ForeColor = System.Drawing.Color.SteelBlue;
            this.PhoneNo.Location = new System.Drawing.Point(391, 136);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(110, 17);
            this.PhoneNo.TabIndex = 28;
            this.PhoneNo.Text = "Phone Number";
            // 
            // PhoneNoTxtBox
            // 
            this.PhoneNoTxtBox.Location = new System.Drawing.Point(391, 153);
            this.PhoneNoTxtBox.Name = "PhoneNoTxtBox";
            this.PhoneNoTxtBox.Size = new System.Drawing.Size(122, 20);
            this.PhoneNoTxtBox.TabIndex = 27;
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
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Address.ForeColor = System.Drawing.Color.SteelBlue;
            this.Address.Location = new System.Drawing.Point(393, 89);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(61, 17);
            this.Address.TabIndex = 26;
            this.Address.Text = "Address";
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(393, 106);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(122, 20);
            this.AddressTxtBox.TabIndex = 25;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.DOB.ForeColor = System.Drawing.Color.SteelBlue;
            this.DOB.Location = new System.Drawing.Point(175, 136);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(97, 17);
            this.DOB.TabIndex = 24;
            this.DOB.Text = "Date Of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker.Location = new System.Drawing.Point(175, 153);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker.TabIndex = 23;
            // 
            // GenderPicker
            // 
            this.GenderPicker.Font = new System.Drawing.Font("Constantia", 9F);
            this.GenderPicker.FormattingEnabled = true;
            this.GenderPicker.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.GenderPicker.Location = new System.Drawing.Point(310, 107);
            this.GenderPicker.Name = "GenderPicker";
            this.GenderPicker.Size = new System.Drawing.Size(67, 22);
            this.GenderPicker.TabIndex = 22;
            this.GenderPicker.Text = "Gender";
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.PatientName.ForeColor = System.Drawing.Color.SteelBlue;
            this.PatientName.Location = new System.Drawing.Point(175, 90);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(100, 17);
            this.PatientName.TabIndex = 21;
            this.PatientName.Text = "Patient Name";
            // 
            // PatientNameTxtBox
            // 
            this.PatientNameTxtBox.Location = new System.Drawing.Point(175, 107);
            this.PatientNameTxtBox.Name = "PatientNameTxtBox";
            this.PatientNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.PatientNameTxtBox.TabIndex = 20;
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
            this.Title.Location = new System.Drawing.Point(371, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(83, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Patients";
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.PatientsDB);
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Controls.Add(this.EditButton);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.Email);
            this.MainPanel.Controls.Add(this.EmailtxtBox);
            this.MainPanel.Controls.Add(this.PhoneNo);
            this.MainPanel.Controls.Add(this.PhoneNoTxtBox);
            this.MainPanel.Controls.Add(this.Address);
            this.MainPanel.Controls.Add(this.AddressTxtBox);
            this.MainPanel.Controls.Add(this.DOB);
            this.MainPanel.Controls.Add(this.dateTimePicker);
            this.MainPanel.Controls.Add(this.GenderPicker);
            this.MainPanel.Controls.Add(this.PatientName);
            this.MainPanel.Controls.Add(this.PatientNameTxtBox);
            this.MainPanel.Controls.Add(this.CloseIcon);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 430);
            this.MainPanel.TabIndex = 6;
            // 
            // ReceptionistPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionistPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionistPatients";
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddAppointmentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox AddDoctors;
        private System.Windows.Forms.PictureBox AddPatientIcon;
        private System.Windows.Forms.DataGridView PatientsDB;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailtxtBox;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.TextBox PhoneNoTxtBox;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox GenderPicker;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.TextBox PatientNameTxtBox;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Doctors;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Appointments;
        private System.Windows.Forms.PictureBox AddAppointmentIcon;
    }
}