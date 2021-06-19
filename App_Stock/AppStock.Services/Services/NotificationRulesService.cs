using AppStock.Persistence.Repositries;
using System;
using System.Collections.Generic;
using System.Text;
using AppStock.core.Models;
using System.Threading.Tasks;
using APPSTOCK.Core.Models;

namespace AppStock.Services
{
    public class NotificationRulesService
    {
        private NotificationRulesRepository _notificationrulesRepository;

        public NotificationRulesService(NotificationRulesRepository moduleRepository)
        {
            _notificationrulesRepository = moduleRepository;
        }
        public async Task<List<ProjectsModel>> GetAllProjectRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllProjectRecords(node, flag);
            return result;
        }

        public async Task<List<ResponseModel>> SaveProjectRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveProjectRecords(node, flag);
            return result;
        }

        public async Task<List<NotificationActionsModel>> GetAllActionRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllActionRecords(node, flag);
            return result;
        }

        public async Task<List<ResponseModel>> SaveActionRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveActionRecords(node, flag);
            return result;
        }
        public async Task<List<NotificationSubActionsModel>> GetAllSubActionRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllSubActionRecords(node, flag);
            return result;
        }

        public async Task<List<ResponseModel>> SaveSubActionRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveSubActionRecords(node, flag);
            return result;
        }

        public async Task<List<NotificationEntityTypeModel>> GetAllEntityTypeRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllEntityTypeRecords(node, flag);
            return result;
        }

        public async Task<List<ResponseModel>> SaveEntityTypeRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveEntityTypeRecords(node, flag);
            return result;
        }

        public async Task<List<NotificationChannelsModel>> GetAllChannelRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllChannelRecords(node, flag);
            return result;
        }

        public async Task<List<ResponseModel>> SaveChannelRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveChannelRecords(node, flag);
            return result;
        }
        public async Task<List<NotificationRecipientsModel>> GetAllRecipientRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.GetAllRecipientRecords(node, flag);
            return result;
        }
      
        public async Task<List<ResponseModel>> SaveRecords(string node, int flag)
        {
            var result = await _notificationrulesRepository.SaveRecords(node, flag);
            return result;
        }

       
    }
}
