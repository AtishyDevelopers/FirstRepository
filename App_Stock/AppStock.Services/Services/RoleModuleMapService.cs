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
    public class RoleModuleMapService
    {
        private RoleModuleMapRepository _RoleModuleMapRepository;

        public RoleModuleMapService(RoleModuleMapRepository RoleModuleMapRepository)
        {
            _RoleModuleMapRepository = RoleModuleMapRepository;
        }
        public async Task<List<RoleModuleMapModel>> GetAllRoleModuleMap(string node, int flag)
        {
            var result = await _RoleModuleMapRepository.GetAllRoleModuleMap(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveRoleModuleMap(string node, int flag)
        {
            var result = await _RoleModuleMapRepository.SaveRoleModuleMap(node, flag);
            return result;
        }

    }
}
