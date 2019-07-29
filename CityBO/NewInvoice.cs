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
    public partial class NewInvoice : Form
    {
        public NewInvoice()
        {
            InitializeComponent();
        }

        public string OrderNumFill
        {
            get { return OrderNum.Text; }
            set { OrderNum.Text = value; }
        }

        public string InvoiceNumFill
        {
            get { return InvoiceNum.Text; }
            set { InvoiceNum.Text = value; }
        }

        public string ToPayFill
        {
            get { return ToPay.Text; }
            set { ToPay.Text = value; }
        }

        public string NoExtraAmountFill
        {
            get { return NoExtraAmount.Text; }
            set { NoExtraAmount.Text = value; }
        }

        public string ToPayDateFill
        {
            set
            {
                ToPayDate.Text = value;
            }

            get
            {
                DateTime dtTL = new DateTime();
                dtTL = DateTime.ParseExact(ToPayDate.Text, "dd.MM.yyyy HH:mm",System.Globalization.CultureInfo.InvariantCulture);
                string TL;
                TL = dtTL.ToString("yyyyMMddHHmm");
                return TL;
            }
        }

        

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBut_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            
            string crInv = "insert into invoices(ordernum,id,sum,timelimit,psum,ptime,state) value(" + OrderNumFill + ","+ InvoiceNumFill + ","+ ToPayFill + ","+ ToPayDateFill + "00,0,19000101000000,1)";
            //MessageBox.Show(crInv);
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(crInv, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
