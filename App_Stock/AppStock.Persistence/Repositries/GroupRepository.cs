using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace AppStock.Persistence.Repositries
{
  public  class GroupRepository
    {
        private IRepository _repository;
        public GroupRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GroupModel>> GetAllGroup(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<GroupModel>("sp_mst_group", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveGroup(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_group", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> EditGroup(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_group", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> DeleteGroup(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_group", new object[] { node.ToString(), flag });
            return result;
        }

    }
}
