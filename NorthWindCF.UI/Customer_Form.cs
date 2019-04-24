using NorthWindCF.BLL;
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
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetCustomers();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Form frm = new Order_Form();
            frm.ShowDialog((string)dataGridView1.SelectedRows[0].Cells["CustomerID"].Value);

        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
