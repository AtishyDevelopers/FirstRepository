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
   public class AddColumnRepository
    {
        private IRepository _repository;
        public AddColumnRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AddColumnModel>> GetAllTableName(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<AddColumnModel>("sp_mst_table_alteration", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveColumn(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_table_alteration", new object[] { node.ToString(), flag });
            return result;
        }

    }
}
