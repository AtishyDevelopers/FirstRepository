using AppStock.core.Models;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services
{
    public class RulesNotificationService
    {
        private RulesNotificationRepository _notificationrulesRepository;

        public RulesNotificationService(RulesNotificationRepository moduleRepository)
        {
            _notificationrulesRepository = moduleRepository;
        }

        public async Task<List<NotificationRulesModel>> GetAllNotificationRulesRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllNotificationRulesRecords(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveNotificationRules(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveNotificationRules(node, flag);
            return result;
        }
    }
}
