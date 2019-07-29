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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CityBO
{
    public partial class MainFormBO : Form
    {
        public MainFormBO()
        {
            InitializeComponent();
            
        }

        private void поискЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form orderSeachForm = new OrderSearchForm();
            orderSeachForm.MdiParent = this;
            orderSeachForm.Show();
            
        }

        private void MainFormBO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private DataTable Orders()
        //{
        //    DataTable ordersDatas = new DataTable();

        //    string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        //    using (MySqlConnection con = new MySqlConnection(connString))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM orders", con))
        //        {
        //            con.Open();
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            ordersDatas.Load(reader);
        //        }
        //    }

        //    return ordersDatas;
        //}



    }
}
