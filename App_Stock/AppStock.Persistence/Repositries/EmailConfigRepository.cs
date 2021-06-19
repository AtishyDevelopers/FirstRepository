using AppStock.core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
    public class EmailConfigRepository
    {
        private IRepository _repository;
        public EmailConfigRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmailConfig>> GetMailDetails(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<EmailConfig>("Mailer.USP_M_GetMailDetails", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
