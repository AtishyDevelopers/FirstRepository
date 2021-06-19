using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
  public  class MenuFormMapRepository
    {
        private IRepository _repository;
        public MenuFormMapRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MenuFormMapModel>> GetAllMenuFormMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<MenuFormMapModel>("sp_menu_form_map", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveMenuFormMap(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_menu_form_map", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
