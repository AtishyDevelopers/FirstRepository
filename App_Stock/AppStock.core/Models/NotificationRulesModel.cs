using AppStock.core.Common;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStock.core.Models
{
   public class NotificationRulesModel: BaseModel
    {
        public int RulesId { get; set; }
        public string RulesName { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public int ActionId { get; set; }
        public string ActionName { get; set; }

        public int SubActionId { get; set; }
        public string SubActionName { get; set; }

        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }

        public List<NotificationSubActionsModel> SubActionList { get; set; }
        public List<NotificationEntityTypeModel> EntityTypeList { get; set; }
        public List<RolesModel> RoleList { get; set; }
        public List<NotificationChannelsModel> ChannelList { get; set; }
    }
}
