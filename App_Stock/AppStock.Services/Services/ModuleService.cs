using AppStock.Persistence;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services
{
  public class ModuleService
    {

        private ModuleRepository _moduleRepository;

        public ModuleService(ModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
        public async Task<List<ModulesModel>> GetAllModule(string node, int flag)
        {
            var result = await _moduleRepository.GetAllModule(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveModule(string node, int flag)
        {
            var result = await _moduleRepository.SaveModule(node, flag);
            return result;
        }

    }
}
