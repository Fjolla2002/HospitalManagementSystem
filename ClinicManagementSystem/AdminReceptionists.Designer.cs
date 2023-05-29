namespace ClinicManagementSystem
{
    partial class AdminReceptionists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReceptionists));
            this.Doctors = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.ReceptionistsDB = new System.Windows.Forms.DataGridView();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Dashboard = new System.Windows.Forms.Label();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.EmailtxtBox = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.PhoneNoTxtBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderPicker = new System.Windows.Forms.ComboBox();
            this.ReceptionistName = new System.Windows.Forms.Label();
            this.ReceptionistNameTxtBox = new System.Windows.Forms.TextBox();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Receptionists = new System.Windows.Forms.Label();
            this.AddDoctors = new System.Windows.Forms.PictureBox();
            this.AddReceptionistIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
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
            // ReceptionistsDB
            // 
            this.ReceptionistsDB.BackgroundColor = System.Drawing.Color.White;
            this.ReceptionistsDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceptionistsDB.Location = new System.Drawing.Point(175, 236);
            this.ReceptionistsDB.Name = "ReceptionistsDB";
            this.ReceptionistsDB.Size = new System.Drawing.Size(494, 158);
            this.ReceptionistsDB.TabIndex = 36;
            this.ReceptionistsDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceptionistsDB_CellContentClick);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(526, 153);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(122, 20);
            this.PasswordTxtBox.TabIndex = 35;
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
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.SteelBlue;
            this.Password.Location = new System.Drawing.Point(526, 133);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(71, 17);
            this.Password.TabIndex = 34;
            this.Password.Text = "Password";
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
            // ReceptionistName
            // 
            this.ReceptionistName.AutoSize = true;
            this.ReceptionistName.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.ReceptionistName.ForeColor = System.Drawing.Color.SteelBlue;
            this.ReceptionistName.Location = new System.Drawing.Point(175, 90);
            this.ReceptionistName.Name = "ReceptionistName";
            this.ReceptionistName.Size = new System.Drawing.Size(136, 17);
            this.ReceptionistName.TabIndex = 21;
            this.ReceptionistName.Text = "Receptionist Name";
            // 
            // ReceptionistNameTxtBox
            // 
            this.ReceptionistNameTxtBox.Location = new System.Drawing.Point(175, 107);
            this.ReceptionistNameTxtBox.Name = "ReceptionistNameTxtBox";
            this.ReceptionistNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.ReceptionistNameTxtBox.TabIndex = 20;
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
            this.Title.Size = new System.Drawing.Size(131, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Receptionists";
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.ReceptionistsDB);
            this.MainPanel.Controls.Add(this.PasswordTxtBox);
            this.MainPanel.Controls.Add(this.Password);
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
            this.MainPanel.Controls.Add(this.ReceptionistName);
            this.MainPanel.Controls.Add(this.ReceptionistNameTxtBox);
            this.MainPanel.Controls.Add(this.CloseIcon);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 430);
            this.MainPanel.TabIndex = 5;
            // 
            // AdminReceptionists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminReceptionists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminReceptionists";
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddReceptionistIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Doctors;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.DataGridView ReceptionistsDB;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailtxtBox;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.TextBox PhoneNoTxtBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox GenderPicker;
        private System.Windows.Forms.Label ReceptionistName;
        private System.Windows.Forms.TextBox ReceptionistNameTxtBox;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label Receptionists;
        private System.Windows.Forms.PictureBox AddDoctors;
        private System.Windows.Forms.PictureBox AddReceptionistIcon;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel MainPanel;
    }
}