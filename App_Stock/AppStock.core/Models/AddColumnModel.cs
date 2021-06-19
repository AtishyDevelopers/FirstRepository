using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
   public class AddColumnModel
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
    }
}
