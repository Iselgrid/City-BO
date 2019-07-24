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

        


    }
}
