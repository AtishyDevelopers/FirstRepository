using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
  public  class Employees
    {
        public int? EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int? Age { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public DateTime? AuditTS { get; set; }
    }
}
