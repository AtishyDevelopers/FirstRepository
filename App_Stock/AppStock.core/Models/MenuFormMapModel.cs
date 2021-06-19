using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
  public  class MenuFormMapModel:BaseModel
    {
        public int? MenuFormMapId { get; set; }
        public int? MenuId { get; set; }
        public int? FormId { get; set; }
        //public string MenuFormFormPath { get; set; }
      //  public int? ModuleId { get; set; }

    }
}
