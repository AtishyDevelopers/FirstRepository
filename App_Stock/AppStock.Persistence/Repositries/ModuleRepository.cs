using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence
{
    public class ModuleRepository
    {

        private IRepository _repository;
        public ModuleRepository(IRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<ModulesModel>> GetAllModule(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ModulesModel>("sp_mst_module", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveModule(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_module", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
