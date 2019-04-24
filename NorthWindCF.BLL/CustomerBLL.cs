using NorthWindCF.DAL;
using NorthWindCF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.BLL
{
    public class CustomerBLL
    {
       static NorthWindDbContext db = new NorthWindDbContext();

       public static List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        public static int AddCustomer(Customer customer)
        {
            Customer c = new Customer();
            c.Address = customer.Address;
            c.City = customer.City;
            c.CompanyName = customer.CompanyName;
            c.ContactName = customer.ContactName;
            c.Country = customer.Country;
            c.Phone = customer.Phone;
            c.PostalCode = customer.PostalCode;
            c.Region = customer.Region;
            c.Fax = customer.Fax;
            c.ContactTitle = customer.ContactTitle;
            c.CustomerID = customer.CustomerID;

            db.Customers.Add(c);
            return db.SaveChanges();
        }
    }
}
