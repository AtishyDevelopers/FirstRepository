using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    public class UserGroupsModel
    {
        public short? UserGroupID { get; set; }
        public string UserGroupName { get; set; }
    }

    [Keyless]
    public class UserGroupRolesModel
    {
        //public short? UserGroupRolesID { get; set; }
        public short? UserGroupID { get; set; }
        public short? RoleID { get; set; }
        public string UserGroupName { get; set; }
        public string RoleName { get; set; }
    }
}

