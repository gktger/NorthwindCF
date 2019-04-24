using NorthWindCF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.DAL.Mapping
{
    public class OrderMapping : EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            ToTable("Orders");
            HasKey(o => o.OrderID);
        }
    }
}
