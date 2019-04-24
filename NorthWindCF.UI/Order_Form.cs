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
    public partial class Order_Form : Form
    {
        public Order_Form()
        {
            InitializeComponent();
        }

       // public string CustomerID;


        public void ShowDialog(string customerID)
        {
            dataGridView1.DataSource = OrderBLL.GetOrders(customerID);
            this.ShowDialog();
        }



    }
}
