using System;
using AppStock.core.Common;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
   public class GroupModel:BaseModel
    {
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public int? OrderBy { get; set; }
       
    }
}
