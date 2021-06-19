using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
  public  class NotificationFeedModel
    {
        public int UserId { get; set; }
        
        public string NotificationFirst { get; set; }
        public string NotificationSecond { get; set; }
    }
}
