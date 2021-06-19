using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
   public class NotificationSubActionsModel : BaseModel
    {
        public int SubActionId { get; set; }
        public string SubActionName { get; set; }
    }
}
