using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class RoleModuleMapModel : BaseModel
    {

        public int? RoleModuleMapId { get; set; }
        public int? ModuleId { get; set; }
        public int? RoleId { get; set; }

    }
}
