using AppStock.core.Models;
using AppStock.Persistence.Repositries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services
{
    public class SendMailService
    {
        private SendMailRepository _sendMailRepository;

        public SendMailService(SendMailRepository sendMailRepository)
        {
            _sendMailRepository = sendMailRepository;
        }

        public async Task<List<NotificationRulesModel>> GetAllNotificationRulesRecords(string node, int flag)
        {
            var result = await _sendMailRepository.GetAllNotificationRules(node, flag);
            return result;
        }
        //public async Task<List<UsersMaster>> GetUserDetails(string node, int flag)
        //{
        //    var result = await _sendMailRepository.GetUserDetails(node, flag);
        //    return result;
        //}

        public async Task<List<SendMailModel>> GetUserDetails(string RoleId)
        {
            var result = await _sendMailRepository.GetUserDetails(RoleId);
            return result;
        }

    }
}
