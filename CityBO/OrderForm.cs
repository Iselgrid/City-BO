using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public string OrderCreateT
        {
            get { return OrderCreateTime.Text; }
            set { OrderCreateTime.Text = value; }
        }

        public string PriceAmountFill
        {
            get { return PriceAmount.Text; }
            set { PriceAmount.Text = value; }
        }

        public string TimeLimitFill
        {
            get { return TimeLimit.Text; }
            set { TimeLimit.Text = value; }
        }

        public string PaidAmountFill
        {
            get { return PaidAmount.Text; }
            set { PaidAmount.Text = value; }
        }

        public string ToPayAmountFill
        {
            get { return ToPayAmount.Text; }
            set { ToPayAmount.Text = value; }
        }

        public string EmailFill
        {
            get { return Email.Text; }
            set { Email.Text = value; }
        }

        public string PhoneNumberFill
        {
            get { return PhoneNumber.Text; }
            set { PhoneNumber.Text = value; }
        }


        public OrderForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void ToPayButton_Click(object sender, EventArgs e)
        {
            string res;
            string SendCommand = "SELECT count(*) FROM invoices WHERE ordernum=" + this.OrderNumber + " and state=1";
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    res = reader["count(*)"].ToString();
                }
            }

            if(res != "1")
            {
                MessageBox.Show("По заказу уже есть ожидающие оплату счета");
            }
            else
            {
                int invNumber = Convert.ToInt32(res) + 1;
                InvoiceCreate(invNumber);
                MessageBox.Show("OK test");
            }


        }

        private void InvoiceCreate(int invNumber)
        {
            NewInvoice invoice = new NewInvoice();
            invoice.OrderNumFill = OrderNumber;
            invoice.InvoiceNumFill = invNumber.ToString();
            invoice.Show();
        }


    }
}
