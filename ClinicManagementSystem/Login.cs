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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-413VNFC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");


        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {

            RolePicker.SelectedIndex = 0;
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (RolePicker.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position!");
            }
            else if (RolePicker.SelectedIndex == 0)
            {
                if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                {
                    MessageBox.Show("Enter both Admin Name and Password");
                }
                else if (UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "12345")
                {
                    AdminDashboard obj = new AdminDashboard();
                    obj.Show();
                    this.Hide();
           
                }
                else
                {
                    MessageBox.Show("Wrong Admin Name or Password");
                }
            }
            else if (RolePicker.SelectedIndex == 1) 
            {
                if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                {
                    MessageBox.Show("Enter both Doctor Name and Password");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM DoctorTbl WHERE DocName = '" + UsernameTextBox.Text + "' AND DocPass = '" + PasswordTextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        DoctorsDashboard dd = new DoctorsDashboard(UsernameTextBox.Text);
                    
                        dd.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found!");
                    }
                    con.Close();
                }
            }
            else if (RolePicker.SelectedIndex == 2)
            {
                if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                {
                    MessageBox.Show("Enter both Receptionist Name and Password");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTbl where ReceptName='" + UsernameTextBox.Text + "' and ReceptPass='" + PasswordTextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        ReceptionistDashboard rd = new ReceptionistDashboard();
                        rd.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist not found!");
                    }
                    con.Close();
                }

            }
        }
    }
}
