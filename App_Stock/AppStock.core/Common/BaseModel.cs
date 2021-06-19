using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Common
{
    public class BaseModel
    {
        public int? CreatedById { get; set; }
        public string CreatedByIP { get; set; }
        public string ModifiedByIP  { get; set; }
        public int? ModifiedById { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //  public int? flag { get; set; }
    }
}
