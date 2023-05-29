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
    public partial class ReceptionistAppointments : Form
    {
        public ReceptionistAppointments()
        {
            InitializeComponent();
            GetPatID();
            GetDocID();
            DisplayRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private string currentPatientID = "";
        private string currentDoctorID = "";
        private string currentPatientName = "";
        private string currentDoctorName = "";
        private DateTime currentAppointmentDateTime;
        private TimeSpan currentAppointmentTime;

        int Key = 0;

        private void DisplayRecords()
        {
            con.Open();
            string Query = "Select * from AppointmentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AppointmentsDB.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            PatientIDPicker.Text = "";
            PatientNameTxtBox.Text = "";
            DoctorIDPicker.Text = "";
            DoctorNameTxtBox.Text = "";
            dateTimePicker.Value = DateTime.Now.Date;

        }

        private void GetPatID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PatientID from PatientTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatientID", typeof(string));
            dt.Load(rdr);
            DataRow row = dt.NewRow();
            row["PatientID"] = "Patient ID";
            dt.Rows.InsertAt(row, 0);
            PatientIDPicker.DisplayMember = "PatientID";
            PatientIDPicker.ValueMember = "PatientID";
            PatientIDPicker.DataSource = dt;
            PatientIDPicker.SelectedIndex = 0;
            con.Close();
        }
        private void GetDocID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DoctorID from DoctorTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DoctorID", typeof(string));
            dt.Load(rdr);
            DataRow row = dt.NewRow();
            row["DoctorID"] = "Doctor ID";
            dt.Rows.InsertAt(row, 0);
            DoctorIDPicker.DisplayMember = "DoctorID";
            DoctorIDPicker.ValueMember = "DoctorID";
            DoctorIDPicker.DataSource = dt;
            con.Close();
        }

        private void GetPatName()
        {
            con.Open();
            string Query = "Select * from PatientTbl where PatientID=" + PatientIDPicker.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientNameTxtBox.Text = dr["PatName"].ToString();
            }
            con.Close();
        }

        private void GetDocName()
        {
            con.Open();
            string Query = "Select * from DoctorTbl where DoctorID=" + DoctorIDPicker.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DoctorNameTxtBox.Text = dr["DocName"].ToString();
            }
            con.Close();
        }

 


        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPatientIcon_Click(object sender, EventArgs e)
        {
            ReceptionistPatients rp = new ReceptionistPatients();
            rp.Show();
            this.Hide();
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            ReceptionistPatients rp = new ReceptionistPatients();
            rp.Show();
            this.Hide();
        }

        private void AddDoctors_Click(object sender, EventArgs e)
        {
            ReceptionistDoctors rd = new ReceptionistDoctors();
            rd.Show();
            this.Hide();
        }

        private void Doctors_Click(object sender, EventArgs e)
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


        private bool PatientAppointmentExist(int patientID, DateTime appointmentDate, TimeSpan appointmentTime)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AppointmentTbl WHERE PatientID = @PID AND AppointmentDate = @AD AND AppointmentTime = @AT", con);
            cmd.Parameters.AddWithValue("@PID", patientID);
            cmd.Parameters.AddWithValue("@AD", appointmentDate);
            cmd.Parameters.AddWithValue("@AT", appointmentTime);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private bool DoctorAppointmentExist(int doctorID,DateTime appointmentDate, TimeSpan appointmentTime)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AppointmentTbl WHERE DoctorID = @DID AND AppointmentDate = @AD AND AppointmentTime = @AT", con);
            cmd.Parameters.AddWithValue("@DID", doctorID);
            cmd.Parameters.AddWithValue("@AD", appointmentDate);
            cmd.Parameters.AddWithValue("@AT", appointmentTime);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if(PatientIDPicker.Text == ""|| PatientNameTxtBox.Text == "" || DoctorIDPicker.Text == "" || DoctorNameTxtBox.Text == "" || dateTimePicker.Value == DateTime.MinValue ||timePicker.Value == DateTime.MinValue)
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                try
                {
                    int patientID = Convert.ToInt32(PatientIDPicker.SelectedValue);
                    int doctorID = Convert.ToInt32(DoctorIDPicker.SelectedValue);
                    if (PatientAppointmentExist(patientID, dateTimePicker.Value.Date, timePicker.Value.TimeOfDay))
                    {
                        MessageBox.Show("This Patient has an appointment at this time.");
                        Clear();
                        return;
                    }
                    else if(DoctorAppointmentExist(doctorID, dateTimePicker.Value, timePicker.Value.TimeOfDay))
                    {
                        MessageBox.Show("This Doctor has an appointment at this time.");
                        Clear();
                        return;
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AppointmentTbl(PatientID,PatientName,DoctorID,DoctorName,AppointmentDate,AppointmentTime)values(@PID,@PN,@DID,@DN,@AD,@AT)", con);
                    cmd.Parameters.AddWithValue("@PID", PatientIDPicker.Text);
                    cmd.Parameters.AddWithValue("@PN", PatientNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DID", DoctorIDPicker.Text);
                    cmd.Parameters.AddWithValue("@DN", DoctorNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@AD", dateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AT", timePicker.Value.TimeOfDay);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Appointment Added!");
                    DisplayRecords();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void PatientIDPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (PatientIDPicker.SelectedIndex != 0)
            {
                GetPatName();
            }
        }

        private void DoctorIDPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (DoctorIDPicker.SelectedIndex != 0)
            {
                GetDocName();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an Appointment!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from AppointmentTbl where AppointmentID=@AKey", con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Deleted!");
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

        private void AppointmentsDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AppointmentsDB.Rows.Count - 1)
            {
                DataGridViewRow row = AppointmentsDB.Rows[e.RowIndex];

                PatientIDPicker.Text = row.Cells["PatientID"].Value.ToString();
                PatientNameTxtBox.Text = row.Cells["PatientName"].Value.ToString();
                DoctorIDPicker.Text = row.Cells["DoctorID"].Value.ToString();
                DoctorNameTxtBox.Text = row.Cells["DoctorName"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["AppointmentDate"].Value);
                timePicker.Value = DateTime.Parse(row.Cells["AppointmentTime"].Value.ToString());

                currentPatientID = PatientIDPicker.Text;
                currentDoctorID = DoctorIDPicker.Text;
                currentPatientName = PatientNameTxtBox.Text;
                currentDoctorName = DoctorNameTxtBox.Text;
                currentAppointmentDateTime = dateTimePicker.Value;
                currentAppointmentTime = timePicker.Value.TimeOfDay;

                Key = Convert.ToInt32(row.Cells["AppointmentID"].Value);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PatientIDPicker.Text == "" || PatientNameTxtBox.Text == "" || DoctorIDPicker.Text == "" || DoctorNameTxtBox.Text == "" || dateTimePicker.Value == DateTime.MinValue || timePicker.Value == DateTime.MinValue)
            {
                MessageBox.Show("Fill all fields!");
            }
            else if(PatientIDPicker.Text == currentPatientID && PatientNameTxtBox.Text == currentPatientName &&
            DoctorIDPicker.Text == currentDoctorID && DoctorNameTxtBox.Text == currentDoctorName &&
            dateTimePicker.Value == currentAppointmentDateTime && timePicker.Value.TimeOfDay == currentAppointmentTime)
            {
                MessageBox.Show("No changes to update.");
            }
            else
            {
                try
                {
                    int patientID = Convert.ToInt32(PatientIDPicker.SelectedValue);
                    int doctorID = Convert.ToInt32(DoctorIDPicker.SelectedValue);
                    if (PatientIDPicker.Text != currentPatientID && PatientAppointmentExist(patientID, dateTimePicker.Value, timePicker.Value.TimeOfDay))
                    {
                        MessageBox.Show("This patient has already an appointment at this time .");
                        Clear();
                        return;
                    }
                    else if (DoctorIDPicker.Text != currentDoctorID && DoctorAppointmentExist(doctorID, dateTimePicker.Value, timePicker.Value.TimeOfDay))
                    {
                        MessageBox.Show("This doctor has already an appointment at this time .");
                        Clear();
                        return;
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update AppointmentTbl set PatientID=@PID,PatientName=@PN,DoctorID=@DID,DoctorName=@DN,AppointmentDate=@AD, AppointmentTime =@AT where AppointmentID=@AKey", con);
                    cmd.Parameters.AddWithValue("@PID", PatientIDPicker.Text);
                    cmd.Parameters.AddWithValue("@PN", PatientNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DID", DoctorIDPicker.Text);
                    cmd.Parameters.AddWithValue("@DN", DoctorNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@AD", dateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AT", timePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Appointment Edited!");
                    DisplayRecords();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
