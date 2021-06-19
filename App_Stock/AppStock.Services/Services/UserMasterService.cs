using AppStock.Persistence.Repositries;
using System;
using System.Collections.Generic;
using System.Text;
using AppStock.core.Models;
using System.Threading.Tasks;
using APPSTOCK.Core.Models;

namespace AppStock.Services
{
    public class UserMasterService
    {
        private UserMasterRepository _userRepository;

        public UserMasterService(UserMasterRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<UsersMaster>> GetAllUser(string node, int flag)
        {
            var result = await _userRepository.GetAllUser(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveUser(string node, int flag)
        {
            var result = await _userRepository.SaveUser(node, flag);
            return result;
        }


public async Task<LoginModel> Login(string username, string password)
        {
            var result = await _userRepository.Login(username, password);
            return result;
        }
        public async Task<UserDetailModel> UserDetails(string username, string password)
        {
            var result = await _userRepository.UserDetails(username, password);
            return result;
        }
    }
}
