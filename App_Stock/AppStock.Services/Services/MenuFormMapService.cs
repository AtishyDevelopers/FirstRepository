using AppStock.core.Models;
using AppStock.Persistence;
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace AppStock.Services.Services
{
   public class MenuFormMapService
    {
        private MenuFormMapRepository _menuformmapRepository;

        public MenuFormMapService(MenuFormMapRepository menuformmapRepository)
        {
            _menuformmapRepository = menuformmapRepository;
        }
        public async Task<List<MenuFormMapModel>> GetAllMenuFormMap(string node, int flag)
        {
            var result = await _menuformmapRepository.GetAllMenuFormMap(node, flag);
            return result;
        }
        public async Task<List<ResponseModel>> SaveMenuFormMap(string node, int flag)
        {
            var result = await _menuformmapRepository.SaveMenuFormMap(node, flag);
            return result;
        }
    }
}
