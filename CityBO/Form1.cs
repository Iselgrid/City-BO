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
    public partial class MainFormBO : Form
    {
        public MainFormBO()
        {
            InitializeComponent();
        }

        private void поискЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form orderSeachForm = new OrderSearchForm();
            orderSeachForm.MdiParent = this;
            orderSeachForm.Show();
        }
    }
}
