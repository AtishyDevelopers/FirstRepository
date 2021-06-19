using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class NotificationEntityTypeModel : BaseModel
    {
        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
    }
}
