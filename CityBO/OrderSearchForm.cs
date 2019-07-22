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
    public partial class OrderSearchForm : Form
    {
        public OrderSearchForm()
        {
            InitializeComponent();
        }

        private void OrderSearchBut_Click(object sender, EventArgs e)
        {
            try
            {
                OrderSearchListOut.DataSource = OrdersSearchListView(OrderTextBoxOSF.Text);
            }
            catch
            {
                return;
            }
        }

        private DataTable OrdersSearchListView(string orderNum)
        {
            DataTable ordersList = new DataTable();
            string SendCommand = "SELECT id,CreatTime,Price,State,Title FROM orders WHERE id=" + orderNum;
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

        private void OrderSearchListOut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Simple_Order order = new Simple_Order(OrderSearchListOut.Rows[0].Cells[0].Value.ToString());
        }
    }
}
