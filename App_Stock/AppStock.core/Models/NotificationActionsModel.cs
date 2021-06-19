using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class NotificationActionsModel : BaseModel
    {
        public int ActionId { get; set; }
        public string ActionName { get; set; }

    }
}
