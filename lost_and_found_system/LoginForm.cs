using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace lost_and_found_system
{
    public partial class LoginForm : Form
    {
        private string connectionString = "server=localhost;user id=root;password=jerald;database=lostandfoundsystem;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM users WHERE email = @email AND password = @password";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DashboardForm dashboard = new DashboardForm();
                        dashboard.Show();
                        this.Hide(); // hide login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials.");
                    }
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide(); // hide login form
        }
    }
}
