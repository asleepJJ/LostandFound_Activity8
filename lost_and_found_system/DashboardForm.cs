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
using MySql.Data.MySqlClient;

namespace lost_and_found_system
{
    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataLost();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataFound();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadDataUsers();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LoadDataCategories();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            LoadDataLocations();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LoadDataLogs();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from claims";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public void LoadDataLost()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from lost_items";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public void LoadDataFound()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from found_items";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public void LoadDataUsers()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from users";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public void LoadDataCategories()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from categories";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public void LoadDataLocations()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from locations";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public void LoadDataLogs()
        {
            string conString = "server=localhost;uid=root;pwd=jerald;database=lostandfoundsystem;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from logs";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
}