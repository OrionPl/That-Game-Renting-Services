using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dapper;

namespace That_Game_Renting_Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool LogIn()
        {
            try
            {
                MySqlConnection sql = new MySqlConnection(@"uid=test;Password=connect;Server=192.168.1.214;Database=testchamber;SslMode=none");
                sql.Open();
                if (sql.Query(@"select password from logininfo where username = " + loginTB + ";") == passTB)
                {
                    MessageBox.Show("Logged in successfully");
                }
                else
                {
                    MessageBox.Show("Log in unsuccessful");
                }
                sql.Close();
            }
            catch (MySqlException se)
            {
                MessageBox.Show("Cannot connect to servers - " + se);
            }

            return true;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (LogIn())
            {

            }
        }
    }
}
