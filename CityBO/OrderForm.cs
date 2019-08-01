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


        public OrderForm(string order)
        {
            InitializeComponent();
            OrderFormFill(order);
            
            this.MdiParent = MainFormBO.ActiveForm;
            this.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void ToPayButton_Click(object sender, EventArgs e)
        {
            string res = DB.DBCountConnect("invoices", "ordernum='" + OrderNumber + "' and state=1");
            int invNumber = Convert.ToInt32(DB.DBCountConnect("invoices"))+1;

            if (res != "1")
            {
                MessageBox.Show("По заказу уже есть ожидающие оплату счета");
            }
            else
            {
                InvoiceCreate(invNumber.ToString());
            }


        }

        private void InvoiceCreate(string invNumber)
        {
            NewInvoice invoice = new NewInvoice(this);
            invoice.UpdateEventHandler += NewInvoice_UpdateEventHandler1;
            invoice.OrderNumFill = OrderNumber;
            invoice.InvoiceNumFill = invNumber;
            invoice.Show();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cTBODBDataSet1);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "cTBODBDataSet4.invoices". При необходимости она может быть перемещена или удалена.
            //this.invoicesTableAdapter.Fill(this.cTBODBDataSet4.invoices);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "cTBODBDataSet3.paxes". При необходимости она может быть перемещена или удалена.
            //this.paxesTableAdapter.Fill(this.cTBODBDataSet3.paxes);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "cTBODBDataSet2.flights". При необходимости она может быть перемещена или удалена.
            //this.flightsTableAdapter.Fill(this.cTBODBDataSet2.flights);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "cTBODBDataSet1.orders". При необходимости она может быть перемещена или удалена.
            ////this.ordersTableAdapter.Fill(this.cTBODBDataSet1.orders);

        }

        public void OrderFormFill(string order)
        {
            DataTable dt = new DataTable();
            dt = DB.DBConnect2("orders", "id='" + order + "'");
            OrderNum.Text = dt.Rows[0][0].ToString();
            creatTimeTextBox.Text = dt.Rows[0][1].ToString();
            Email.Text = dt.Rows[0][5].ToString();
            PhoneNumber.Text = dt.Rows[0][6].ToString();
            OrderFlightsListView.DataSource = DB.DBConnect2("flights", "id='" + order + "'");
            PassengersListView.DataSource = DB.DBConnect2("paxes", "id='" + order + "'");
            InvoicesListView.DataSource = DB.DBConnect2("invoices", "ordernum='" + order + "'");
            PriceDetales(order);
        }

        public void PriceDetales(string order)
        {
            DataTable dt = new DataTable();
            dt = DB.DBCountConnect("sum", "invoices", "state!='0'");
            int sum = 0;
            foreach (DataRow pr in dt.Rows)
            {
                sum += Convert.ToInt32(pr[0]);
            }
            PriceAmountFill = sum.ToString();

            dt = DB.DBCountConnect("sum", "invoices", "state ='2'");
            sum = 0;
            foreach (DataRow pr in dt.Rows)
            {
                sum += Convert.ToInt32(pr[0]);
            }
            PaidAmountFill = sum.ToString();

            dt = DB.DBCountConnect("sum", "invoices", "state ='1'");
            sum = 0;
            foreach (DataRow pr in dt.Rows)
            {
                sum += Convert.ToInt32(pr[0]);
            }
            ToPayAmountFill = sum.ToString();
        }

        private void NewInvoice_UpdateEventHandler1(object sender, NewInvoice.UpdateEventArgs args)
        {
            OrderFormFill(OrderNumber);
        }

    }
}
