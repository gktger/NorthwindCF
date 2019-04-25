using NorthWindCF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.DAL.Mapping
{
    public class EmployeeMapping:EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            ToTable("Employees");
            HasKey(x=>x.EmployeeID);
        }
    }
}
