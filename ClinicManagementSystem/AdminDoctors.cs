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
    public partial class AdminDoctors : Form
    {
        public AdminDoctors()
        {
            InitializeComponent();
            DisplayRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private string currentDoctorName = "";
        private string currentGender = "";
        private string currentAddress = "";
        private string currentEmail = "";
        private DateTime currentDOB;
        private string currentPhoneNo = "";
        private string currentSpecialization = "";
        private decimal currentExperience;
        private string currentPassword = "";

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayRecords()
        {
            con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDB.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            AdminDoctors adoc = new AdminDoctors();
            adoc.Show();
            this.Hide();
        }

        private void AddDoctors_Click(object sender, EventArgs e)
        {
            AdminDoctors adoc = new AdminDoctors();
            adoc.Show();
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

        private void Clear()
        {
            DoctorNameTxtBox.Text = "";
            GenderPicker.Text = "Gender";
            AddressTxtBox.Text = "";
            EmailtxtBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            DoctorPhoneNo.Text = "";
            SpecializationPicker.Text = "Specialization";
            numericExperience.Value = 0;
            PasswordTxtBox.Text = "";
        }

        private bool sameEmail(string email)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DoctorTbl WHERE DocEmail = @Email", con);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool sameName(string name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DoctorTbl WHERE DocName = @DN", con);
            cmd.Parameters.AddWithValue("@DN", name);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool samePhoneNo(string phoneNo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DoctorTbl WHERE DocPhoneNo = @DPN", con);
            cmd.Parameters.AddWithValue("@DPN", phoneNo);
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
            if (DoctorNameTxtBox.Text == "" || GenderPicker == null || AddressTxtBox.Text == "" ||
                  EmailtxtBox.Text == "" || dateTimePicker == null || DoctorPhoneNo.Text == "" ||
                  SpecializationPicker == null || numericExperience == null || PasswordTxtBox.Text == "")
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
                        if (sameName(DoctorNameTxtBox.Text))
                        {
                            MessageBox.Show("A Doctor with the same name already exists.");
                            Clear();
                            return;
                        }

                        else if (sameEmail(EmailtxtBox.Text))
                        {
                            MessageBox.Show("A Doctor with the same email already exists.");
                            Clear();
                            return;
                        }
                        else if (samePhoneNo(DoctorPhoneNo.Text))
                        {
                            MessageBox.Show("A Doctor with the same phone number already exists.");
                            Clear();
                            return;
                        }

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DocGender,DocAddress,DocEmail,DocDOB,DocPhoneNo,DocSpecialization,DocExperience,DocPass)values(@DN,@DG,@DA,@DE,@DDOB,@DPN,@DS,@DES,@DP)", con);
                        cmd.Parameters.AddWithValue("@DN", DoctorNameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@DG", GenderPicker.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DA", AddressTxtBox.Text);
                        cmd.Parameters.AddWithValue("@DE", EmailtxtBox.Text);
                        cmd.Parameters.AddWithValue("@DDOB", dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@DPN", DoctorPhoneNo.Text);
                        cmd.Parameters.AddWithValue("@DS", SpecializationPicker.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DES", numericExperience.Value);
                        cmd.Parameters.AddWithValue("@DP", password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Added!");
                        con.Close();
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
        int Key = 0;

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DoctorNameTxtBox.Text == "" || GenderPicker == null || AddressTxtBox.Text == "" ||
                  EmailtxtBox.Text == "" || dateTimePicker == null || DoctorPhoneNo.Text == "" ||
                  SpecializationPicker == null || numericExperience == null || PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else if (DoctorNameTxtBox.Text == currentDoctorName && GenderPicker.SelectedItem.ToString() == currentGender &&
             AddressTxtBox.Text == currentAddress && EmailtxtBox.Text == currentEmail &&
             dateTimePicker.Value == currentDOB && DoctorPhoneNo.Text == currentPhoneNo &&
             SpecializationPicker.SelectedItem.ToString() == currentSpecialization &&
             numericExperience.Value == currentExperience && PasswordTxtBox.Text == currentPassword)
            {
                MessageBox.Show("No changes to update.");
            }
            else
            {
                try
                {
                    if (DoctorNameTxtBox.Text != currentDoctorName && sameName(DoctorNameTxtBox.Text))
                    {
                        MessageBox.Show("A Doctor with the same name already exists.");
                        Clear();
                        return;
                    }

                    else if (EmailtxtBox.Text != currentEmail && sameEmail(EmailtxtBox.Text))
                    {
                        MessageBox.Show("A Doctor with the same email already exists.");
                        Clear();
                        return;
                    }
                    else if (DoctorPhoneNo.Text != currentPhoneNo && samePhoneNo(DoctorPhoneNo.Text))
                    {
                        MessageBox.Show("A Doctor with the same phone number already exists.");
                        Clear();
                        return;
                    }

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update DoctorTbl set DocName=@DN,DocGender=@DG,DocAddress=@DA,DocEmail=@DE,DocDOB=@DDOB,DocPhoneNo=@DPN,DocSpecialization=@DS,DocExperience=@DES,DocPass=@DP where DoctorID=@DKey", con);
                    cmd.Parameters.AddWithValue("@DN", DoctorNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DG", GenderPicker.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DA", AddressTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DE", EmailtxtBox.Text);
                    cmd.Parameters.AddWithValue("@DDOB", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@DPN", DoctorPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@DS", SpecializationPicker.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DES", numericExperience.Value);
                    cmd.Parameters.AddWithValue("@DP", PasswordTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Edited!");
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
                MessageBox.Show("Select a Doctor!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTbl where DoctorID=@DKey", con);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted!");
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

        private void DoctorsDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DoctorsDB.Rows[e.RowIndex];

                DoctorNameTxtBox.Text = row.Cells["DocName"].Value.ToString();
                GenderPicker.Text = row.Cells["DocGender"].Value.ToString();
                AddressTxtBox.Text = row.Cells["DocAddress"].Value.ToString();
                EmailtxtBox.Text = row.Cells["DocEmail"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["DocDOB"].Value);
                DoctorPhoneNo.Text = row.Cells["DocPhoneNo"].Value.ToString();
                SpecializationPicker.Text = row.Cells["DocSpecialization"].Value.ToString();
                numericExperience.Value = Convert.ToDecimal(row.Cells["DocExperience"].Value);
                PasswordTxtBox.Text = row.Cells["DocPass"].Value.ToString();

                currentDoctorName = DoctorNameTxtBox.Text;
                currentGender = GenderPicker.Text;
                currentAddress = AddressTxtBox.Text;
                currentEmail = EmailtxtBox.Text;
                currentDOB = dateTimePicker.Value;
                currentPhoneNo = DoctorPhoneNo.Text;
                currentSpecialization = SpecializationPicker.Text;
                currentExperience = numericExperience.Value;
                currentPassword = PasswordTxtBox.Text;


                Key = Convert.ToInt32(row.Cells["DoctorID"].Value);
            }
        }

        private void EmailtxtBox_TextChanged(object sender, EventArgs e)
        {

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
