using NorthWindCF.DAL.Mapping;
using NorthWindCF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.DAL
{
    public class NorthWindDbContext : DbContext
    {
        public NorthWindDbContext() : base("name=ConnectionString")
        {
            Database.SetInitializer<NorthWindDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new OrderMapping());

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

    }
}
