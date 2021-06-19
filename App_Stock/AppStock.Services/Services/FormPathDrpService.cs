using AppStock.core.Models;
using AppStock.Persistence;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services.Services
{
  public  class FormPathDrpService
    {
        private FormPathDrpRepository _FormPathDrpRepository;

        public FormPathDrpService(FormPathDrpRepository FormPathDrpRepository)
        {
            _FormPathDrpRepository = FormPathDrpRepository;
        }
        public async Task<List<FormPathDrpModel>> GetAllFormpath(string node, int flag)
        {
            var result = await _FormPathDrpRepository.GetAllFormpath(node, flag);
            return result;
        }
    }
}
