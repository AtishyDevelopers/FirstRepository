using AppStock.Persistence;
using APPSTOCK.Core.Models;
using AppStock.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppStock.Persistence.Repositries;

namespace AppStock.Services.Services
{
   public class RoleService
    {
        private RoleRepository _roleRepository;

        public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<List<RoleModel>> GetAllRole(string node, int flag)
        {
            var result = await _roleRepository.GetAllRole(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveRole(string node, int flag)
        {
            var result = await _roleRepository.SaveRole(node, flag);
            return result;
        }
    }
}
