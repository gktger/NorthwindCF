using NorthWindCF.DAL;
using NorthWindCF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.BLL
{
    public class OrderBLL
    {
        static NorthWindDbContext db = new NorthWindDbContext();

        public static List<Order> GetOrders(string id)
        {
            return db.Orders.Where(x => x.CustomerID == id).ToList();
        }
    }
}
