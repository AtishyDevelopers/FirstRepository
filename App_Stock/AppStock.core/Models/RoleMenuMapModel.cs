using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
  public  class RoleMenuMapModel:BaseModel
    {
        public int? RoleMenuMapId { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        
    }
}
