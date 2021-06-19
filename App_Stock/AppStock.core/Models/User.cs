using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    public class User
    {
        public short Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Fullname { get { return String.Concat(Firstname, " ", Lastname); } }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }

       public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
  
