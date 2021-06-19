using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class NotificationRecipientsModel: BaseModel
    {
        public int RecipientId { get; set; }
        public string RecipientName { get; set; }
    }
}
