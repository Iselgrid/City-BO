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
    public partial class OrderForm : Form
    {
        public string OrderNumber
        {
            get { return OrderNum.Text; }
            set { OrderNum.Text = value; }
        }

        public OrderForm()
        {
            InitializeComponent();
        }

        private DataTable OrderFillDatas(string orderNum)
        {
            DataTable ordersList = new DataTable();
            string SendCommand = "SELECT * FROM orders WHERE id=" + orderNum;
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    ordersList.Load(reader);
                }
            }
            return ordersList;
        }


    }
}
