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
            TimeLimitDatas.Text = DateTime.Now.AddDays(1.0).ToString();
            
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

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBut_Click(object sender, EventArgs e)
        {
            string datas = "'" + OrderNumFill + "','" + InvoiceNumFill + "','" + ToPayFill + "','" + TimeLimitDatas.Text.ToString() + ":00','0','01.01.1990 00:00:00','1','" + NoExtraAmountFill + "','" + DateTime.Now.ToString() + "','" + Comment.ToString() + "'";
            DB.DBSentReq("invoices", "ordernum,id,sum,timelimit,psum,ptime,state,netto,crtime,comment", datas);
            
            this.Close();
        }
    }
}
