using AppStock.core.Models;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services
{
    public class EmailConfigService
    {
        private EmailConfigRepository _emailRepository;

        public EmailConfigService(EmailConfigRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }
        public async Task<List<EmailConfig>> GetMailDetails(string node, int flag)
        {
            var result = await _emailRepository.GetMailDetails(node, flag);
            return result;
        }
        //public async Task<List<ResponseModel>> SaveMenu(string node, int flag)
        //{
        //    var result = await _menuRepository.SaveMenu(node, flag);
        //    return result;
        //}
    }
}
