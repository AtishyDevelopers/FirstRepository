using AppStock.core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
    public class SendMailRepository
    {
        private IRepository _repository;
        public SendMailRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<NotificationRulesModel>> GetAllNotificationRules(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationRulesModel>("sp_mst_NotificationRules", new object[] { node.ToString(), flag });
            return result;
        }
        //public async Task<List<UsersMaster>> GetUserDetails(string node, int flag)
        //{
        //    var result = await _repository.ExecuteStoredProcedureWithList<UsersMaster>("sp_GetUserDetails_FilterWithRoleId", new object[] { node.ToString(), flag });
        //    return result;
        //}
        public async Task<List<SendMailModel>> GetUserDetails(string RoleId)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<SendMailModel>("sp_GetUserDetails_FilterWithRoleId", new[] { RoleId });
          //  UsersMaster loginModel = result;
            return result;

        }
    }
}
