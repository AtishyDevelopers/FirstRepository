using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class EmailConfig
    {
       // public EmailConfig();

        public string FromEmailid { get; set; }
        public string Id { get; set; }
        public bool isactive { get; set; }
        public string password { get; set; }
        public string PortNumber { get; set; }
        public string smtpServer { get; set; }
        public string User { get; set; }
    }
}
