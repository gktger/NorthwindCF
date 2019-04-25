using NorthWindCF.DAL;
using NorthWindCF.Entity;
using NorthWindCF.Entity.DTO;
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

        public static List<Order> GetAllOrders()
        {
            return db.Orders.ToList();


        }

        public static List<OrderDTO> SearchOrder(string cn)
        {
            var a = from c in db.Customers
                    join o in db.Orders
                    on c.CustomerID equals o.CustomerID
                    where c.CompanyName.Contains(cn)
                    select new OrderDTO
                    {
                        OrderId = o.OrderID,
                        ContactName=c.ContactName,
                        ShipCountry=o.ShipCountry
                   };

            return a.ToList();
        }

        public static List<EmployeeDTO> SearchEmployee(string search)
        {
            var a = from e in db.Employees
                    join o in db.Orders
                    on e.EmployeeID equals o.EmployeeID
                    join c in db.Customers
                    on o.CustomerID equals c.CustomerID
                    where c.ContactName.Contains(search) || e.FirstName.Contains(search)
                    select new EmployeeDTO
                    {
                        OrderId = o.OrderID,
                        ShipCountry = o.ShipCountry,
                        CustomerName = c.ContactName,
                        EmployeeName = e.FirstName
                    };

            return a.ToList();

        }

    }
}
