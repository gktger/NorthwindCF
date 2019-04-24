using NorthWindCF.BLL;
using NorthWindCF.Entity;
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
    public partial class AddCustomer_Form : Form
    {
        public AddCustomer_Form()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string kelime = txt_CompanyName.Text;
            string CustomerID = kelime.Substring(0,3);

            Customer customer = new Customer();
            customer.City = txt_City.Text;
            customer.Address = txt_address.Text;
            customer.CompanyName = txt_CompanyName.Text;
            customer.ContactName = txt_ContactName.Text;
            customer.ContactTitle = txt_ContactName.Text;
            customer.Country = txt_ContactName.Text;
            customer.Fax = txt_Fax.Text;
            customer.Phone = txt_Phone.Text;
            customer.PostalCode = txt_PostalCode.Text;
            customer.Region = txt_Region.Text;
            customer.CustomerID = CustomerID;

           int eklendiMi = CustomerBLL.AddCustomer(customer);

            if (eklendiMi >0)
            {
                MessageBox.Show("Test");
            }
            else
            {
                MessageBox.Show("Test");
            }
        }

        private void AddCustomer_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
