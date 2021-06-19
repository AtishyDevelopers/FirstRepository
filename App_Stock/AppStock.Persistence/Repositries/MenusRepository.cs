using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace AppStock.Persistence.Repositries
{
   public class MenusRepository
    {
        private IRepository _repository;
        public MenusRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MenusModel>> GetAllMenus(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<MenusModel>("sp_mst_menu", new object[] { node.ToString(), flag });
            return result;
        }
        public async Task<List<ResponseModel>> SaveMenus(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_menu", new object[] { node.ToString(), flag });
            return result;
        }
    }
}
