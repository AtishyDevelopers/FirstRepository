using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    public class RolesModel:BaseModel
    {
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
