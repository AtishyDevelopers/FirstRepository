
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
    public class BaseRepository
    {
        private IRepository _repository;

        public BaseRepository(IRepository repository)
        {
            _repository = repository;
        }



     
    }
}
