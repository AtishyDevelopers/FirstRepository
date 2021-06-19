using AppStock.Persistence.Repositries;
using System;
using System.Collections.Generic;
using System.Text;
using AppStock.core.Models;
using System.Threading.Tasks;
using APPSTOCK.Core.Models;

namespace AppStock.Services.Services
{
  public  class AddColumnService
    {
        private AddColumnRepository _AddColumnRepository;

        public AddColumnService(AddColumnRepository AddColumnRepository)
        {
            _AddColumnRepository = AddColumnRepository;
        }


        public async Task<List<AddColumnModel>> GetAllTableName(string node, int flag)
        {
            var result = await _AddColumnRepository.GetAllTableName(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveColumn(string node, int flag)
        {
            var result = await _AddColumnRepository.SaveColumn(node, flag);
            return result;
        }

    }
}
