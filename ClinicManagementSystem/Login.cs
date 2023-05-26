using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

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
        }
    }
}
