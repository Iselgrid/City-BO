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
                string res = DB.DBCountConnect("users", "uname='" + textBox1.Text + "' and password='" + textBox2.Text + "'");

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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            


        }
    }
}
