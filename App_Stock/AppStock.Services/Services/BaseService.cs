
using AppStock.Persistence.Repositries;
using APPSTOCK.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Services.Services
{
    public class BaseService
    {

        private BaseRepository _baseRepository;

        public BaseService(BaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }

      

    }
}