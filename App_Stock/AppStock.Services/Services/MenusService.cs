using AppStock.Persistence;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services.Services
{
   public class MenusService
    {
        private MenusRepository _menusRepository;

        public MenusService(MenusRepository menusRepository)
        {
            _menusRepository = menusRepository;
        }
        public async Task<List<MenusModel>> GetAllMenus(string node, int flag)
        {
            var result = await _menusRepository.GetAllMenus(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveMenus(string node, int flag)
        {
            var result = await _menusRepository.SaveMenus(node, flag);
            return result;
        }

    }
}
