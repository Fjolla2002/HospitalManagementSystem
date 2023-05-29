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
    public partial class ReceptionistDoctors : Form
    {
        public ReceptionistDoctors()
        {
            InitializeComponent();
            DisplayRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private void DisplayRecords()
        {
            con.Open();
            string Query = "Select DoctorID,DocName,DocAddress,DocEmail,DocPhoneNo,DocSpecialization,DocExperience from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDB.DataSource = ds.Tables[0];
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

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
