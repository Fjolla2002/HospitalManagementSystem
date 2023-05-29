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
    public partial class ReceptionistDashboard : Form
    {
        public ReceptionistDashboard()
        {
            InitializeComponent();
            CountPatients();
            CountAppointments();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private void CountPatients()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalPatientsNr.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountAppointments()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from AppointmentTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalAppointmentsNr.Text = dt.Rows[0][0].ToString();
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
            ReceptionistDoctors rp = new ReceptionistDoctors();
            rp.Show();
            this.Hide();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            ReceptionistDoctors rp = new ReceptionistDoctors();
            rp.Show();
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
