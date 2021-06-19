using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
  public  class RoleModel:BaseModel
    {
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
