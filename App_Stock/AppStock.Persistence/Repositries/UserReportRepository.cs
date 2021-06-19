using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
  public  class UserReportRepository
    {

        private IRepository _repository;
        public UserReportRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UserReportModel>> GetAllUserReport(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<UserReportModel>("sp_mst_user_report", new object[] { node.ToString(), flag });
            return result;
        }

    }
}
