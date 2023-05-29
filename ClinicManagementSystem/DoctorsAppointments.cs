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
    public partial class DoctorsAppointments : Form
    {
        public DoctorsAppointments(string doctorName)
        {
            InitializeComponent();
            loggedDoctorName = doctorName;
            DisplayAppointments(loggedDoctorName, AppointmentsDB);

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private string loggedDoctorName;

        public string LoggedDoctorName
        {
            get { return loggedDoctorName; }
            set { loggedDoctorName = value; }
        }

        private void DisplayAppointments(string doctorName, DataGridView dataGridView)
        {
            SqlCommand command = new SqlCommand("SELECT PatientName, AppointmentDate, AppointmentTime FROM AppointmentTbl WHERE DoctorName = @DoctorName", con);
            command.Parameters.AddWithValue("@DoctorName", doctorName);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();

            dataGridView.DataSource = dataTable;
        }

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
