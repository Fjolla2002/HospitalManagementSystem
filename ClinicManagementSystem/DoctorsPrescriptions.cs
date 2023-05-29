using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class DoctorsPrescriptions : Form
    {
        public DoctorsPrescriptions(string doctorName)
        {
            InitializeComponent();
            loggedDoctorName = doctorName;
            GetAppointmentID(loggedDoctorName);
            DisplayRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private string loggedDoctorName;

        public string LoggedDoctorName
        {
            get { return loggedDoctorName; }
            set { loggedDoctorName = value; }
        }


        private string currentAppointmentID = "";
        private string currentPatientName = "";
        private string currentPrescription = "";


        int Key = 0;


        private void DisplayRecords()
        {
            con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionsDB.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            appointmentPicker.Text = "";
            PatientNameTxtBox.Text = "";
            PrescriptonTextBox.Text = "";
           

        }

        private void GetAppointmentID(string doctorName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT AppointmentID FROM AppointmentTbl WHERE DoctorName = @DoctorName", con);
            cmd.Parameters.AddWithValue("@DoctorName", doctorName);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AppointmentID", typeof(string));
            dt.Load(rdr);
            con.Close();

            DataRow row = dt.NewRow();
            row["AppointmentID"] = "Appointment ID"; 
            dt.Rows.InsertAt(row, 0);

            appointmentPicker.DisplayMember = "AppointmentID";
            appointmentPicker.ValueMember = "AppointmentID";
            appointmentPicker.DataSource = dt;
            appointmentPicker.SelectedIndex = 0;
        }
        private void GetPatientName()
        {
            con.Open();
            string query = "SELECT * FROM AppointmentTbl WHERE AppointmentID = " + appointmentPicker.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientNameTxtBox.Text = dr["PatientName"].ToString();
            }
            con.Close();
        }

        private bool PrescriptionExists(int appointmentID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PrescriptionTbl WHERE AppointmentID = @AID", con);
            cmd.Parameters.AddWithValue("@AID", appointmentID);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private void appointmentPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (appointmentPicker.SelectedIndex != 0)
            {
                GetPatientName();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (appointmentPicker.Text == "" || PatientNameTxtBox.Text == "" || PrescriptonTextBox.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                try
                {
                    int appointmentID = Convert.ToInt32(appointmentPicker.SelectedValue);
                    if (PrescriptionExists(appointmentID))
                    {
                        MessageBox.Show("Prescription for this appointment exists.");

                        return;
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(AppointmentID,PatientName,PrescriptionText)values(@AID,@PN,@PT)", con);
                    cmd.Parameters.AddWithValue("@AID", appointmentID);
                    cmd.Parameters.AddWithValue("@PN", PatientNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PT", PrescriptonTextBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayRecords();
                    Clear();
                    MessageBox.Show("Appointment Added!");
                    
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
                MessageBox.Show("Select an Prescription!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PrescriptionTbl where PrescriptionID=@PKey", con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Deleted!");
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

        private void PrescriptionsDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < PrescriptionsDB.Rows.Count - 1)
            {
                DataGridViewRow row = PrescriptionsDB.Rows[e.RowIndex];

                appointmentPicker.Text = row.Cells["AppointmentID"].Value.ToString();
                PatientNameTxtBox.Text = row.Cells["PatientName"].Value.ToString();
                PrescriptonTextBox.Text = row.Cells["PrescriptionText"].Value.ToString();

     
                currentAppointmentID = appointmentPicker.Text;
                currentPatientName = PatientNameTxtBox.Text;
                currentPrescription = PrescriptonTextBox.Text;

                Key = Convert.ToInt32(row.Cells["PrescriptionID"].Value);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (appointmentPicker.Text == "" || PatientNameTxtBox.Text == "" || PrescriptonTextBox.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else if (appointmentPicker.Text == currentAppointmentID && PatientNameTxtBox.Text == currentPatientName &&
            PrescriptonTextBox.Text == currentPrescription )
            {
                MessageBox.Show("No changes to update.");
            }
            else
            {
                try
                {
                    int appointmentID = Convert.ToInt32(appointmentPicker.SelectedValue);
                    if (appointmentPicker.Text != currentAppointmentID && PrescriptionExists(appointmentID))
                    {
                        MessageBox.Show("Already exists a prescription for this appointment.");
                        Clear();
                        return;
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update PrescriptionTbl set AppointmentID=@AID,PatientName=@PN,PrescriptionText=@PT where PrescriptionID=@PKey", con);
                    cmd.Parameters.AddWithValue("@AID", appointmentPicker.Text);
                    cmd.Parameters.AddWithValue("@PN", PatientNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PT", PrescriptonTextBox.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Prescription Edited!");
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CloseIcon_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void DashboardIcon_Click(object sender, EventArgs e)
        {
            DoctorsDashboard dd = new DoctorsDashboard(loggedDoctorName);
            dd.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DoctorsDashboard dd = new DoctorsDashboard(loggedDoctorName);
            dd.Show();
            this.Hide();
        }

        private void AddAppointmentIcon_Click(object sender, EventArgs e)
        {
            DoctorsAppointments da = new DoctorsAppointments(loggedDoctorName);
            da.Show();
            this.Hide();
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            DoctorsAppointments da = new DoctorsAppointments(loggedDoctorName);
            da.Show();
            this.Hide();
        }

        private void AddPrescriptionIcon_Click(object sender, EventArgs e)
        {
            DoctorsPrescriptions da = new DoctorsPrescriptions(loggedDoctorName);
            da.Show();
            this.Hide();
        }

        private void Prescriptions_Click(object sender, EventArgs e)
        {
            DoctorsPrescriptions da = new DoctorsPrescriptions(loggedDoctorName);
            da.Show();
            this.Hide();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            loggedDoctorName = null;
            li.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            loggedDoctorName = null;
            li.Show();
            this.Hide();
        }
    }
}
