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
    public partial class ReceptionistPatients : Form
    {
        public ReceptionistPatients()
        {
            InitializeComponent();
            DisplayRecords();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private string currentPatName = "";
        private string currentGender = "";
        private string currentAddress = "";
        private string currentEmail = "";
        private DateTime currentDOB;
        private string currentPhoneNo = "";

        int Key = 0;

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayRecords()
        {
            con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDB.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            PatientNameTxtBox.Text = "";
            GenderPicker.Text = "Gender";
            AddressTxtBox.Text = "";
            EmailtxtBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            PhoneNoTxtBox.Text = "";
        }

        private bool sameEmail(string email)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PatientTbl WHERE PatEmail = @Email", con);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool sameName(string name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PatientTbl WHERE PatName = @PN", con);
            cmd.Parameters.AddWithValue("@PN", name);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool samePhoneNo(string phoneNo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PatientTbl WHERE PatPhoneNo = @PPN", con);
            cmd.Parameters.AddWithValue("@PPN", phoneNo);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (PatientNameTxtBox.Text == "" || GenderPicker == null || AddressTxtBox.Text == "" ||
                EmailtxtBox.Text == "" || dateTimePicker == null || PhoneNoTxtBox.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
               
                    try
                    {

                        if (sameName(PatientNameTxtBox.Text))
                        {
                            MessageBox.Show("A Patient with the same name already exists.");
                            Clear();
                            return;
                        }

                        else if (sameEmail(EmailtxtBox.Text))
                        {
                            MessageBox.Show("A Patient with the same email already exists.");
                            Clear();
                            return;
                        }
                        else if (samePhoneNo(PhoneNoTxtBox.Text))
                        {
                            MessageBox.Show("A Patient with the same phone number already exists.");
                            Clear();
                            return;
                        }

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatGender,PatAddress,PatEmail,PatDOB,PatPhoneNo)values(@PN,@PG,@PA,@PE,@PDOB,@PPN)", con);
                        cmd.Parameters.AddWithValue("@PN", PatientNameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@PG", GenderPicker.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PA", AddressTxtBox.Text);
                        cmd.Parameters.AddWithValue("@PE", EmailtxtBox.Text);
                        cmd.Parameters.AddWithValue("@PDOB", dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@PPN", PhoneNoTxtBox.Text);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Patient Added!");
                        DisplayRecords();
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
               
            }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PatientNameTxtBox.Text == "" || GenderPicker == null || AddressTxtBox.Text == "" ||
              EmailtxtBox.Text == "" || dateTimePicker == null || PhoneNo.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else if (PatientNameTxtBox.Text == currentPatName && GenderPicker.SelectedItem.ToString() == currentGender &&
            AddressTxtBox.Text == currentAddress && EmailtxtBox.Text == currentEmail &&
            dateTimePicker.Value == currentDOB && PhoneNoTxtBox.Text == currentPhoneNo)
            {
                MessageBox.Show("No changes to update.");
            }
            else
            {
                try
                {
                    if (PatientNameTxtBox.Text != currentPatName && sameName(PatientNameTxtBox.Text))
                    {
                        MessageBox.Show("A Patient with the same name already exists.");
                        Clear();
                        return;
                    }

                    else if (EmailtxtBox.Text != currentEmail && sameEmail(EmailtxtBox.Text))
                    {
                        MessageBox.Show("A Patient with the same email already exists.");
                        Clear();
                        return;
                    }
                    else if (PhoneNoTxtBox.Text != currentPhoneNo && samePhoneNo(PhoneNoTxtBox.Text))
                    {
                        MessageBox.Show("A Patient with the same phone number already exists.");
                        Clear();
                        return;
                    }

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl set PatName=@PN,PatGender=@PG,PatAddress=@PA,PatEmail=@PE,PatDOB=@PDOB,PatPhoneNo=@PPN where PatientID=@PKey", con);
                    cmd.Parameters.AddWithValue("@PN", PatientNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PG", GenderPicker.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PA", AddressTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PE", EmailtxtBox.Text);
                    cmd.Parameters.AddWithValue("@PDOB", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@PPN", PhoneNoTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Edited!");
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
                MessageBox.Show("Select a Patient!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl where PatientID=@PKey", con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted!");
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

        private void PatientsDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PatientsDB.Rows[e.RowIndex];

                PatientNameTxtBox.Text = row.Cells["PatName"].Value.ToString();
                GenderPicker.Text = row.Cells["PatGender"].Value.ToString();
                AddressTxtBox.Text = row.Cells["PatAddress"].Value.ToString();
                EmailtxtBox.Text = row.Cells["PatEmail"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["PatDOB"].Value);
                PhoneNoTxtBox.Text = row.Cells["PatPhoneNo"].Value.ToString();

                currentPatName = PatientNameTxtBox.Text;
                currentGender = GenderPicker.Text;
                currentAddress = AddressTxtBox.Text;
                currentEmail = EmailtxtBox.Text;
                currentDOB = dateTimePicker.Value;
                currentPhoneNo = PhoneNoTxtBox.Text;

                Key = Convert.ToInt32(row.Cells["PatientID"].Value);
            }
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            ReceptionistPatients rp = new ReceptionistPatients();
            rp.Show();
            this.Hide();
        }

        private void AddPatientIcon_Click(object sender, EventArgs e)
        {
            ReceptionistPatients rp = new ReceptionistPatients();
            rp.Show();
            this.Hide();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            ReceptionistDoctors rd = new ReceptionistDoctors();
            rd.Show();
            this.Hide();
        }

        private void AddDoctors_Click(object sender, EventArgs e)
        {
            ReceptionistDoctors rd = new ReceptionistDoctors();
            rd.Show();
            this.Hide();
        }

        private void AddAppointmentIcon_Click(object sender, EventArgs e)
        {
            ReceptionistAppointments ra = new ReceptionistAppointments();
            ra.Show();
            this.Hide();
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            ReceptionistAppointments ra = new ReceptionistAppointments();
            ra.Show();
            this.Hide();
        }

        private void DashboardIcon_Click(object sender, EventArgs e)
        {
            ReceptionistDashboard rd = new ReceptionistDashboard();
            rd.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ReceptionistDashboard rd = new ReceptionistDashboard();
            rd.Show();
            this.Hide();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }
    }
    }