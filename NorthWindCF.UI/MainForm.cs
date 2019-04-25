using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindCF.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Form frm = new Customer_Form();
            if (Application.OpenForms["Customer_Form"] == null)
            {
                frm.MdiParent = this;
                frm.Show();
            }


        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer_Form frm = new AddCustomer_Form();
            if (Application.OpenForms["AddCustomer_Form"] == null)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void searchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderList_Form frm = new OrderList_Form();
            frm.Show();
        }
    }
}
