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
   public class UserReportService
    {
        private UserReportRepository _UserReportRepository;

        public UserReportService(UserReportRepository UserReportRepository)
        {
            _UserReportRepository = UserReportRepository;
        }
        public async Task<List<UserReportModel>> GetAllUserReport(string node, int flag)
        {
            var result = await _UserReportRepository.GetAllUserReport(node, flag);
            return result;
        }

    }
}
