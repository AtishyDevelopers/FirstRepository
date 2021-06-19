using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace AppStock.Persistence.Repositries
{
  public  class RoleFormsMapRepository
    {
        private IRepository _repository;
        public RoleFormsMapRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<RoleFormsMapModel>> GetAllRoleFormsMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<RoleFormsMapModel>("sp_role_form_map", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveRoleFormsMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_role_form_map", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<RoleFormsMapModel>> GetAllFormpath(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<RoleFormsMapModel>("sp_mst_drp_formpath", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
