using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
   public class UserReportModel
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsDeleted { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }


          }
}
