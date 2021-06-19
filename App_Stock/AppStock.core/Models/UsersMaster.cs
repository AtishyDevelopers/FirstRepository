using AppStock.core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
    public class UsersMaster : BaseModel
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
        public string ColumnName { get; set; }
        public string DataType { get; set; }

    }
}
