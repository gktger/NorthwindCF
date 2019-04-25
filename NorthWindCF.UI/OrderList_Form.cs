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
    public partial class OrderList_Form : Form
    {
        public OrderList_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource=OrderBLL.SearchEmployee(textBox1.Text);
        }

        private void OrderList_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderBLL.GetAllOrders();
        }
    }
}
