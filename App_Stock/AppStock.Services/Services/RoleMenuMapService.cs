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
   public class RoleMenuMapService
    {
        private RoleMenuMapRepository _RoleMenuMapRepository;

        public RoleMenuMapService(RoleMenuMapRepository RoleMenuMapRepository)
        {
            _RoleMenuMapRepository = RoleMenuMapRepository;
        }
        public async Task<List<RoleMenuMapModel>> GetAllRoleMenuMap(string node, int flag)
        {
            var result = await _RoleMenuMapRepository.GetAllRoleMenuMap(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveRoleMenuMap(string node, int flag)
        {
            var result = await _RoleMenuMapRepository.SaveRoleMenuMap(node, flag);
            return result;
        }

    }
}
