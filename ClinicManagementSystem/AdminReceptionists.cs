using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicManagementSystem
{
    public partial class AdminReceptionists : Form
    {
        public AdminReceptionists()
        {
            InitializeComponent();
            DisplayRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        private string currentReceptName = "";
        private string currentGender = "";
        private string currentAddress = "";
        private string currentEmail = "";
        private DateTime currentDOB;
        private string currentPhoneNo = "";
        private string currentPassword = "";
        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardIcon_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void AddReceptionistIcon_Click(object sender, EventArgs e)
        {
            AdminReceptionists ar = new AdminReceptionists();
            ar.Show();
            this.Hide();
        }

        private void Receptionists_Click(object sender, EventArgs e)
        {
            AdminReceptionists ar = new AdminReceptionists();
            ar.Show();
            this.Hide();
        }

        private void AddDoctors_Click(object sender, EventArgs e)
        {
            AdminDoctors adoc = new AdminDoctors();
            adoc.Show();
            this.Hide();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            AdminDoctors adoc = new AdminDoctors();
            adoc.Show();
            this.Hide();
        }

        private void DisplayRecords()
        {
            con.Open();
            string Query = "Select * from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceptionistsDB.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool sameEmail(string email)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ReceptionistTbl WHERE ReceptEmail = @Email", con);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool sameName(string name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ReceptionistTbl WHERE ReceptName = @RN", con);
            cmd.Parameters.AddWithValue("@RN", name);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool samePhoneNo(string phoneNo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ReceptionistTbl WHERE ReceptPhoneNo = @RPN", con);
            cmd.Parameters.AddWithValue("@RPN", phoneNo);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }
        private bool PasswordMeetsCriteria(string password)
        {
            bool hasUppercase = false;
            bool hasSymbol = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUppercase = true;
                else if (char.IsSymbol(c) || char.IsPunctuation(c))
                    hasSymbol = true;
                else if (char.IsDigit(c))
                    hasNumber = true;
            }

            return hasUppercase && hasSymbol && hasNumber;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ReceptionistNameTxtBox.Text == "" || GenderPicker == null || AddressTxtBox.Text == "" ||
                EmailtxtBox.Text == "" || dateTimePicker == null || PhoneNoTxtBox.Text == "" || PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                string password = PasswordTxtBox.Text;
                if (PasswordMeetsCriteria(password))
                {
                    try
                    {

                        if (sameName(ReceptionistNameTxtBox.Text))
                        {
                            MessageBox.Show("A Receptionist with the same name already exists.");
                            Clear();
                            return;
                        }

                        else if (sameEmail(EmailtxtBox.Text))
                        {
                            MessageBox.Show("A Receptionist with the same email already exists.");
                            Clear();
                            return;
                        }
                        else if (samePhoneNo(PhoneNoTxtBox.Text))
                        {
                            MessageBox.Show("A Receptionist with the same phone number already exists.");
                            Clear();
                            return;
                        }

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(ReceptName,ReceptGender,ReceptAddress,ReceptEmail,ReceptDOB,ReceptPhoneNo,ReceptPass)values(@RN,@RG,@RA,@RE,@RDOB,@RPN,@RP)", con);
                        cmd.Parameters.AddWithValue("@RN", ReceptionistNameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@RG", GenderPicker.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RA", AddressTxtBox.Text);
                        cmd.Parameters.AddWithValue("@RE", EmailtxtBox.Text);
                        cmd.Parameters.AddWithValue("@RDOB", dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@RPN", PhoneNoTxtBox.Text);
                        cmd.Parameters.AddWithValue("@RP", PasswordTxtBox.Text);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Receptionist Added!");
                        DisplayRecords();
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one symbol, and one number.");
                }
            }
        }

        private void Clear()
        {
            ReceptionistNameTxtBox.Text = "";
            GenderPicker.Text = "Gender";
            AddressTxtBox.Text = "";
            EmailtxtBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            PhoneNoTxtBox.Text = "";
            PasswordTxtBox.Text = "";
        }

        int Key = 0;
        private void ReceptionistsDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ReceptionistsDB.Rows[e.RowIndex];

                ReceptionistNameTxtBox.Text = row.Cells["ReceptName"].Value.ToString();
                GenderPicker.Text = row.Cells["ReceptGender"].Value.ToString();
                AddressTxtBox.Text = row.Cells["ReceptAddress"].Value.ToString();
                EmailtxtBox.Text = row.Cells["ReceptEmail"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["ReceptDOB"].Value);
                PhoneNoTxtBox.Text = row.Cells["ReceptPhoneNo"].Value.ToString();
                PasswordTxtBox.Text = row.Cells["ReceptPass"].Value.ToString();

                currentReceptName = ReceptionistNameTxtBox.Text;
                currentGender = GenderPicker.Text;
                currentAddress = AddressTxtBox.Text;
                currentEmail = EmailtxtBox.Text;
                currentDOB = dateTimePicker.Value;
                currentPhoneNo = PhoneNoTxtBox.Text;
                currentPassword = PasswordTxtBox.Text;

                Key = Convert.ToInt32(row.Cells["ReceptionistID"].Value);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ReceptionistNameTxtBox.Text == "" || GenderPicker == null || AddressTxtBox.Text == "" ||
               EmailtxtBox.Text == "" || dateTimePicker == null || PhoneNo.Text == "" || PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else if (ReceptionistNameTxtBox.Text == currentReceptName && GenderPicker.SelectedItem.ToString() == currentGender &&
            AddressTxtBox.Text == currentAddress && EmailtxtBox.Text == currentEmail &&
            dateTimePicker.Value == currentDOB && PhoneNoTxtBox.Text == currentPhoneNo 
            && PasswordTxtBox.Text == currentPassword)
            {
                MessageBox.Show("No changes to update.");
            }
            else
            {
                try
                {
                    if (ReceptionistNameTxtBox.Text != currentReceptName && sameName(ReceptionistNameTxtBox.Text))
                    {
                        MessageBox.Show("A Receptionist with the same name already exists.");
                        Clear();
                        return;
                    }

                    else if (EmailtxtBox.Text != currentEmail && sameEmail(EmailtxtBox.Text))
                    {
                        MessageBox.Show("A Receptionist with the same email already exists.");
                        Clear();
                        return;
                    }
                    else if (PhoneNoTxtBox.Text != currentPhoneNo && samePhoneNo(PhoneNoTxtBox.Text))
                    {
                        MessageBox.Show("A Receptionist with the same phone number already exists.");
                        Clear();
                        return;
                    }

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistTbl set ReceptName=@RN,ReceptGender=@RG,ReceptAddress=@RA,ReceptEmail=@RE,ReceptDOB=@RDOB,ReceptPhoneNo=@RPN,ReceptPass=@RP where ReceptionistID=@RKey", con);
                    cmd.Parameters.AddWithValue("@RN", ReceptionistNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@RG", GenderPicker.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RA", AddressTxtBox.Text);
                    cmd.Parameters.AddWithValue("@RE", EmailtxtBox.Text);
                    cmd.Parameters.AddWithValue("@RDOB", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@RPN", PhoneNoTxtBox.Text);
                    cmd.Parameters.AddWithValue("@RP", PasswordTxtBox.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Edited!");
                    con.Close();
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Receptionist!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ReceptionistTbl where ReceptionistID=@RKey", con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Deleted!");
                    con.Close();
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            // Trigger the server form close event in AdminDashboard
            AdminDashboard adminDashboard = Application.OpenForms.OfType<AdminDashboard>().FirstOrDefault();

            Login li = new Login();
            li.Show();
            this.Hide();
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            // Trigger the server form close event in AdminDashboard
            AdminDashboard adminDashboard = Application.OpenForms.OfType<AdminDashboard>().FirstOrDefault();
            Login li = new Login();
            li.Show();
            this.Hide();
        }
    }
}
