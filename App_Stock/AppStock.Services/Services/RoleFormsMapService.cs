using AppStock.Persistence;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace AppStock.Services.Services
{
   public class RoleFormsMapService
    {
        private RoleFormsMapRepository _roleformsmapRepository;

        public RoleFormsMapService(RoleFormsMapRepository roleformsmapRepository)
        {
            _roleformsmapRepository = roleformsmapRepository;
        }
        public async Task<List<RoleFormsMapModel>> GetAllRoleFormsMap(string node, int flag)
        {
            var result = await _roleformsmapRepository.GetAllRoleFormsMap(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveRoleFormsMap(string node, int flag)
        {
            var result = await _roleformsmapRepository.SaveRoleFormsMap(node, flag);
            return result;
        }

        public async Task<List<RoleFormsMapModel>> GetAllFormpath(string node, int flag)
        {
            var result = await _roleformsmapRepository.GetAllFormpath(node, flag);
            return result;
        }
    }
}
