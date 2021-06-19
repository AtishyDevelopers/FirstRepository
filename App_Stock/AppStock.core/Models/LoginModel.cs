using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace AppStock.core.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
       // public int UserId { get; set; }
        //public int? DivisionID { get; set; }
        //public int? RoleID { get; set; }
        //public string? ContactNumber { get; set; }

    }
    public class ChangePasswordModel
    {
        public int userID { get; set; }
        public int createdByID { get; set; }
        public string emailAddress { get; set; }
        public string userPasswordNew { get; set; }
        public string userOTP { get; set; }

    }
    public class MessageResponse
    {
        public string ErrorMessage { get; set; }
    }
    public class UserDetailModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string DoB { get; set; }
        public string Gender { get; set; }
        public string DoJ { get; set; }
        public string DesignationName { get; set; }
        public int DesignationId { get; set; }
        public string EmployeeId { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public int DivisionId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Password { get; set; }

    }
}
