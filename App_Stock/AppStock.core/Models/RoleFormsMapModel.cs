using System;
using System.Collections.Generic;
using System.Text;
using AppStock.core.Common;

namespace APPSTOCK.Core.Models
{
    public class RoleFormsMapModel: BaseModel
{
        //public int? RoleID { get; set; }
        public int? RoleFormMapId { get; set; }
        public int? RoleId { get; set; }
        public int? FormId { get; set; }
    }
}
