﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindCF.Entity.DTO
{
    public class EmployeeDTO
    {
        public string CustomerName { get; set; }
        public int OrderId { get; set; }
        public string ShipCountry { get; set; }
        public string EmployeeName { get; set; }
     
    }
}
