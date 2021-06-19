using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace AppStock.Persistence.Repositries
{
   public class RoleMenuMapRepository
    {
        private IRepository _repository;
        public RoleMenuMapRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<RoleMenuMapModel>> GetAllRoleMenuMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<RoleMenuMapModel>("sp_role_menu_map", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveRoleMenuMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_role_menu_map", new object[] { node.ToString(), flag });
            return result;
        }

    }
}
