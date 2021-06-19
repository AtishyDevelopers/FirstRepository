using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
    public class RulesNotificationRepository
    {
        private IRepository _repository;
        public RulesNotificationRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<NotificationRulesModel>> GetAllNotificationRulesRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationRulesModel>("sp_mst_NotificationRules", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> SaveNotificationRules(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_NotificationRules", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
