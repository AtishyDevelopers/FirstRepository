using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class DepartmentMaster : BaseModel
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
