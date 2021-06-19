using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    public class ModulesModel:BaseModel
    {
        public int? ModuleId { get; set; }
        
        public string ModuleName { get; set; }
        public int OrderBy { get; set; }





    }
}
