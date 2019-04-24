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
    }
}
