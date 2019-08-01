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
            if (OrderTextBoxOSF.Text == "*")
            {
                this.ordersTableAdapter.Fill(this.cTBODBDataSet.orders);
            }
            else
            {
                try
                {
                    OrderSearchListOut.DataSource = DB.DBConnect2("orders", "id='"+OrderTextBoxOSF.Text+"'");
                }
                catch
                {
                    return;
                }
            }
        }

        private void OrderSearchListOut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderForm order = new OrderForm(OrderSearchListOut.Rows[0].Cells[0].Value.ToString());
        }

        private void OrderSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cTBODBDataSet.orders". При необходимости она может быть перемещена или удалена.
            //this.ordersTableAdapter.Fill(this.cTBODBDataSet.orders);

        }
    }
}
