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

    }
}