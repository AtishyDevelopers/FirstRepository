using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
    public class RoleModuleMapRepository
    {
        private IRepository _repository;
        public RoleModuleMapRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<RoleModuleMapModel>> GetAllRoleModuleMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<RoleModuleMapModel>("sp_role_module_map", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveRoleModuleMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_role_module_map", new object[] { node.ToString(), flag });
            return result;
        }

    }
}
