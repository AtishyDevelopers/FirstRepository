using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string SocietyName { get; set; }
        public string Village { get; set; }
        public bool IsActive { get; set; }
        public string password { get; set; }
    }
}
