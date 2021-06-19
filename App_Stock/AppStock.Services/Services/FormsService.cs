using AppStock.Persistence;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace AppStock.Services.Services
{
   public class FormsService
    {
        private FormsRepository _formsRepository;

        public FormsService(FormsRepository formsRepository)
        {
            _formsRepository = formsRepository;
        }
        public async Task<List<FormsModel>> GetAllForms(string node, int flag)
        {
            var result = await _formsRepository.GetAllForms(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveForms(string node, int flag)
        {
            var result = await _formsRepository.SaveForms(node, flag);
            return result;
        }

    }
}
