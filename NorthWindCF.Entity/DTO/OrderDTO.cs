using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.Entity.DTO
{
    public class OrderDTO
    {
        public int  OrderId { get; set; }
        public string ContactName { get; set; }
        public string ShipCountry { get; set; }

    }
}
