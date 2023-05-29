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
using System.Runtime.InteropServices;

namespace ClinicManagementSystem
{
    public partial class AdminDashboard : Form
    {
        private ServerForm sf;
        public AdminDashboard()
        {
            InitializeComponent();
            CountReceptionists();
            CountDoctors();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");

        private void CountReceptionists()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from ReceptionistTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalReceptionistsNr.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountDoctors()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalDoctorsNr.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

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

        private void Doctors_Click(object sender, EventArgs e)
        {
            AdminDoctors adoc = new AdminDoctors();
            adoc.Show();
            this.Hide();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
            sf.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
            sf.Close();
        }

        private void startServer_Click(object sender, EventArgs e)
        {
           sf = new ServerForm();
           sf.Show();
           sf.FormClosed += ServerFormClosedHandler;

        }

        public void ServerFormClosedHandler(object sender, EventArgs e)
        {
            sf.Dispose(); // Dispose the ServerForm instance
            sf = null; // Set the reference to null
        }
    }
}
