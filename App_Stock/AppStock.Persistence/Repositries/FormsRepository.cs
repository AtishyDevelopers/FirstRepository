using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
   public class FormsRepository
    {
        private IRepository _repository;
        public FormsRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<FormsModel>> GetAllForms(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<FormsModel>("sp_mst_form", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveForms(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_form", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
