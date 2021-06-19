using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
   public class RoleRepository
    {
        private IRepository _repository;
        public RoleRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<RoleModel>> GetAllRole(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<RoleModel>("sp_mst_user_role", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveRole(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_user_role", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
