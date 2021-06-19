using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class ProjectsModel:BaseModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
