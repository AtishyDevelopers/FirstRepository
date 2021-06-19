using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppStock.core.Models;
using System.Linq;

namespace AppStock.Persistence.Repositries
{
    public class UserMasterRepository
    {
        private IRepository _repository;
        public UserMasterRepository(IRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<UsersMaster>> GetAllUser(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<UsersMaster>("sp_mst_user_information", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveUser(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_user_information", new object[] { node.ToString(), flag });
            return result;
        }


public async Task<LoginModel> Login(string username, string password)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<LoginModel>("sp_userLogin", new[] { username, password });
            LoginModel loginModel = result.FirstOrDefault();
            return loginModel;

        }
        public async Task<UserDetailModel> UserDetails(string username, string password)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<UserDetailModel>("sp_userLoginDetails", new[] { username, password });
            UserDetailModel loginModel = result.FirstOrDefault();
            return loginModel;

        }
    }
}
