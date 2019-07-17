using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Simple_Order order = new Simple_Order(OrderTextBoxOSF.Text);
         }
    }
}
