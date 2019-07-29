using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string res = DBConnet();

                if (res == "1")
                {
                    this.Hide();
                    MainFormBO mf = new MainFormBO();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка входа");
                return;
            }
            


        }


        public string DBConnet()
        {
            string count = "0";
            string SendCommand = "SELECT count(*) FROM users WHERE uname='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    count = reader["count(*)"].ToString();
                }
            }

            return count;
        }
    }
}
