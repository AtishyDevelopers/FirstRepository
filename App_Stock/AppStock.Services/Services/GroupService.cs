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
   public class GroupService
    {
        private GroupRepository _groupRepository;

        public GroupService(GroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<List<GroupModel>> GetAllGroup(string node, int flag)
        {
            var result = await _groupRepository.GetAllGroup(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveGroup(string node, int flag)
        {
            var result = await _groupRepository.SaveGroup(node, flag);
            return result;
        }

        public async Task<List<ResponseModel>> EditGroup(string node, int flag)
        {
            var result = await _groupRepository.EditGroup(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> DeleteGroup(string node, int flag)
        {
            var result = await _groupRepository.DeleteGroup(node, flag);
            return result;
        }
    }
}
