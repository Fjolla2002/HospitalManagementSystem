using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class DoctorsDashboard : Form
    {
        private ClientForm cf;

        public DoctorsDashboard(string doctorName)
        {
            InitializeComponent();
            loggedDoctorName = doctorName;
            CountPatients(loggedDoctorName, TotalPatientsNr);
            CountAppointments(loggedDoctorName, TotalAppointmentsNr);


        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private string loggedDoctorName;

        public string LoggedDoctorName
        {
            get { return loggedDoctorName; }
            set { loggedDoctorName = value; }
        }

        private void CountPatients(string doctorName, Label textBox)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(DISTINCT PatientName) FROM AppointmentTbl WHERE DoctorName = @DN", con);
            command.Parameters.AddWithValue("@DN", doctorName);
            con.Open();
            int patientCount = (int)command.ExecuteScalar();
            con.Close();
            textBox.Text = patientCount.ToString();
        }
        private void CountAppointments(string doctorName, Label textBox)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM AppointmentTbl WHERE DoctorName = @DN", con);
            command.Parameters.AddWithValue("@DN", doctorName);
            con.Open();
            int patientCount = (int)command.ExecuteScalar();
            con.Close();
            textBox.Text = patientCount.ToString();
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            DoctorsDashboard dd = new DoctorsDashboard(loggedDoctorName);
            dd.Show();
            this.Hide();
        }

        private void DashboardIcon_Click(object sender, EventArgs e)
        {
            DoctorsDashboard dd = new DoctorsDashboard(loggedDoctorName);
            dd.Show();
            this.Hide();
        }

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            loggedDoctorName = "";
            li.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            loggedDoctorName = "";
            li.Show();
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
            DoctorsPrescriptions dp = new DoctorsPrescriptions(loggedDoctorName);
            dp.Show();
            this.Hide();
        }

        private void Prescriptions_Click(object sender, EventArgs e)
        {
            DoctorsPrescriptions dp = new DoctorsPrescriptions(loggedDoctorName);
            dp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cf = new ClientForm(loggedDoctorName);
            cf.Show();
        }
    }
}
