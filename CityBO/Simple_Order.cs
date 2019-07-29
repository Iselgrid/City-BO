using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBO
{
    class Simple_Order
    {

        public void formOpen(string num)
        {
            string orderCreated, paidTime, timeLimit, orderNum, email, phoneNum, price = null, toPay = null, paidSum = null, titul;
            int iPrice = Convert.ToInt32(price), iToPay = Convert.ToInt32(toPay), iPaidSum = Convert.ToInt32(paidSum), state = -1;
            OrderForm order = new OrderForm();
            order.MdiParent = MainFormBO.ActiveForm;


            
            string SendCommand = "SELECT * FROM orders WHERE id=" + num;
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    order.OrderNumber = reader["id"].ToString();
                    order.OrderCreateT = reader["CreatTime"].ToString();
                    order.PriceAmountFill = reader["Price"].ToString();
                    order.TimeLimitFill = reader["TimeLimit"].ToString();
                    order.EmailFill = reader["Email"].ToString();
                    order.PhoneNumberFill = reader["Phone"].ToString();
                }
            }
            FlightsFillOrder(num, order);
            PassengersFillOrder(num, order);
            InvoicesFillOrder(num, order);

            order.Show();
            
        }

        public Simple_Order(string num)
        {
            formOpen(num);
            
        }

        private void FlightsFillOrder (string order, OrderForm form)
        {
            DataTable FlightsList = new DataTable();
            string SendCommand = "SELECT * FROM flights WHERE id=" + order;
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    FlightsList.Load(reader);
                }
            }

            form.OrderFlightsListView.DataSource = FlightsList;
        }

        private void PassengersFillOrder(string order, OrderForm form)
        {
            DataTable PassengersList = new DataTable();
            string SendCommand = "SELECT * FROM paxes WHERE id=" + order;
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    PassengersList.Load(reader);
                }
            }

            form.PassengersListView.DataSource = PassengersList;
        }

        public void InvoicesFillOrder(string order, OrderForm form)
        {
            DataTable InvoicesList = new DataTable();
            string SendCommand = "SELECT * FROM invoices WHERE ordernum=" + order;
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SendCommand, con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    InvoicesList.Load(reader);
                }
            }

            form.InvoicesListView.DataSource = InvoicesList;
        }


    }
}
