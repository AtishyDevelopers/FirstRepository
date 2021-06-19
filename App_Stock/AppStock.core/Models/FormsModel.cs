using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    public class FormsModel:BaseModel
    {
        public int? FormID { get; set; }
        public string FormName { get; set; }
        public string FormDescription { get; set; }
        public int? MenuID { get; set; }
        public int? ModuleID { get; set; }
        public string FormPath { get; set; }
        public string FormIcon { get; set; }
        public int? OrderBy { get; set; }
    }
}
