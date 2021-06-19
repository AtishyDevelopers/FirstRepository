using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class NotificationChannelsModel : BaseModel
    {
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
    }
}
