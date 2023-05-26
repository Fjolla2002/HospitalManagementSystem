namespace ClinicManagementSystem
{
    partial class AdminDoctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDoctors));
            this.Logout = new System.Windows.Forms.Label();
            this.AddReceptionistIcon = new System.Windows.Forms.PictureBox();
            this.Experience = new System.Windows.Forms.Label();
            this.numericExperience = new System.Windows.Forms.NumericUpDown();
            this.SpecializationPicker = new System.Windows.Forms.ComboBox();
            this.Dashboard = new System.Windows.Forms.Label();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.Doctors = new System.Windows.Forms.Label();
            this.DoctorsDB = new System.Windows.Forms.DataGridView();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.EmailtxtBox = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PhoneNoTxtBox = new System.Windows.Forms.Label();
            this.DoctorPhoneNo = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderPicker = new System.Windows.Forms.ComboBox();
            this.DoctorName = new System.Windows.Forms.Label();
            this.DoctorNameTxtBox = new System.Windows.Forms.TextBox();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Receptionists = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.AddDoctors = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDB)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            // Experience
            // 
            this.Experience.AutoSize = true;
            this.Experience.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Experience.ForeColor = System.Drawing.Color.SteelBlue;
            this.Experience.Location = new System.Drawing.Point(298, 177);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(83, 17);
            this.Experience.TabIndex = 56;
            this.Experience.Text = "Experience";
            // 
            // numericExperience
            // 
            this.numericExperience.Location = new System.Drawing.Point(301, 198);
            this.numericExperience.Name = "numericExperience";
            this.numericExperience.Size = new System.Drawing.Size(46, 20);
            this.numericExperience.TabIndex = 55;
            // 
            // SpecializationPicker
            // 
            this.SpecializationPicker.Font = new System.Drawing.Font("Constantia", 9F);
            this.SpecializationPicker.FormattingEnabled = true;
            this.SpecializationPicker.Items.AddRange(new object[] {
            "General Practicioner",
            "Pediatrician",
            "Orthopedist",
            "Pathologist",
            "Emergency physician"});
            this.SpecializationPicker.Location = new System.Drawing.Point(182, 197);
            this.SpecializationPicker.Name = "SpecializationPicker";
            this.SpecializationPicker.Size = new System.Drawing.Size(102, 22);
            this.SpecializationPicker.TabIndex = 54;
            this.SpecializationPicker.Text = "Specialization";
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
            // DoctorsDB
            // 
            this.DoctorsDB.BackgroundColor = System.Drawing.Color.White;
            this.DoctorsDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDB.Location = new System.Drawing.Point(179, 253);
            this.DoctorsDB.Name = "DoctorsDB";
            this.DoctorsDB.Size = new System.Drawing.Size(494, 140);
            this.DoctorsDB.TabIndex = 53;
            this.DoctorsDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDB_CellContentClick);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(395, 197);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(122, 20);
            this.PasswordTxtBox.TabIndex = 52;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.SteelBlue;
            this.Password.Location = new System.Drawing.Point(395, 177);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(71, 17);
            this.Password.TabIndex = 51;
            this.Password.Text = "Password";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Green;
            this.AddButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(533, 138);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 29);
            this.AddButton.TabIndex = 50;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.EditButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(533, 173);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(108, 29);
            this.EditButton.TabIndex = 49;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(533, 208);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 29);
            this.DeleteButton.TabIndex = 48;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.Color.SteelBlue;
            this.Email.Location = new System.Drawing.Point(530, 88);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 17);
            this.Email.TabIndex = 47;
            this.Email.Text = "Email";
            // 
            // EmailtxtBox
            // 
            this.EmailtxtBox.Location = new System.Drawing.Point(530, 105);
            this.EmailtxtBox.Name = "EmailtxtBox";
            this.EmailtxtBox.Size = new System.Drawing.Size(122, 20);
            this.EmailtxtBox.TabIndex = 46;
            this.EmailtxtBox.TextChanged += new System.EventHandler(this.EmailtxtBox_TextChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.Experience);
            this.MainPanel.Controls.Add(this.numericExperience);
            this.MainPanel.Controls.Add(this.SpecializationPicker);
            this.MainPanel.Controls.Add(this.DoctorsDB);
            this.MainPanel.Controls.Add(this.PasswordTxtBox);
            this.MainPanel.Controls.Add(this.Password);
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Controls.Add(this.EditButton);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.Email);
            this.MainPanel.Controls.Add(this.EmailtxtBox);
            this.MainPanel.Controls.Add(this.PhoneNoTxtBox);
            this.MainPanel.Controls.Add(this.DoctorPhoneNo);
            this.MainPanel.Controls.Add(this.Address);
            this.MainPanel.Controls.Add(this.AddressTxtBox);
            this.MainPanel.Controls.Add(this.DOB);
            this.MainPanel.Controls.Add(this.dateTimePicker);
            this.MainPanel.Controls.Add(this.GenderPicker);
            this.MainPanel.Controls.Add(this.DoctorName);
            this.MainPanel.Controls.Add(this.DoctorNameTxtBox);
            this.MainPanel.Controls.Add(this.CloseIcon);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 430);
            this.MainPanel.TabIndex = 5;
            // 
            // PhoneNoTxtBox
            // 
            this.PhoneNoTxtBox.AutoSize = true;
            this.PhoneNoTxtBox.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.PhoneNoTxtBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.PhoneNoTxtBox.Location = new System.Drawing.Point(395, 135);
            this.PhoneNoTxtBox.Name = "PhoneNoTxtBox";
            this.PhoneNoTxtBox.Size = new System.Drawing.Size(110, 17);
            this.PhoneNoTxtBox.TabIndex = 45;
            this.PhoneNoTxtBox.Text = "Phone Number";
            // 
            // DoctorPhoneNo
            // 
            this.DoctorPhoneNo.Location = new System.Drawing.Point(395, 152);
            this.DoctorPhoneNo.Name = "DoctorPhoneNo";
            this.DoctorPhoneNo.Size = new System.Drawing.Size(122, 20);
            this.DoctorPhoneNo.TabIndex = 44;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Address.ForeColor = System.Drawing.Color.SteelBlue;
            this.Address.Location = new System.Drawing.Point(397, 88);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(61, 17);
            this.Address.TabIndex = 43;
            this.Address.Text = "Address";
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(397, 105);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(122, 20);
            this.AddressTxtBox.TabIndex = 42;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.DOB.ForeColor = System.Drawing.Color.SteelBlue;
            this.DOB.Location = new System.Drawing.Point(179, 135);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(97, 17);
            this.DOB.TabIndex = 41;
            this.DOB.Text = "Date Of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker.Location = new System.Drawing.Point(179, 152);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker.TabIndex = 40;
            // 
            // GenderPicker
            // 
            this.GenderPicker.Font = new System.Drawing.Font("Constantia", 9F);
            this.GenderPicker.FormattingEnabled = true;
            this.GenderPicker.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.GenderPicker.Location = new System.Drawing.Point(314, 106);
            this.GenderPicker.Name = "GenderPicker";
            this.GenderPicker.Size = new System.Drawing.Size(67, 22);
            this.GenderPicker.TabIndex = 39;
            this.GenderPicker.Text = "Gender";
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSize = true;
            this.DoctorName.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.DoctorName.ForeColor = System.Drawing.Color.SteelBlue;
            this.DoctorName.Location = new System.Drawing.Point(179, 89);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(96, 17);
            this.DoctorName.TabIndex = 38;
            this.DoctorName.Text = "Doctor Name";
            // 
            // DoctorNameTxtBox
            // 
            this.DoctorNameTxtBox.Location = new System.Drawing.Point(179, 106);
            this.DoctorNameTxtBox.Name = "DoctorNameTxtBox";
            this.DoctorNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.DoctorNameTxtBox.TabIndex = 37;
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
            // AdminDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDoctors";
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDB)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.PictureBox AddReceptionistIcon;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.NumericUpDown numericExperience;
        private System.Windows.Forms.ComboBox SpecializationPicker;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.Label Doctors;
        private System.Windows.Forms.DataGridView DoctorsDB;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailtxtBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label PhoneNoTxtBox;
        private System.Windows.Forms.TextBox DoctorPhoneNo;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox GenderPicker;
        private System.Windows.Forms.Label DoctorName;
        private System.Windows.Forms.TextBox DoctorNameTxtBox;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label Receptionists;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.PictureBox AddDoctors;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}