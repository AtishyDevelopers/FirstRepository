using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
  public  class NotificationFeedRepository
    {
        private IRepository _repository;
        public NotificationFeedRepository(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<NotificationFeedModel>> GetNotificationFeed(string UserId)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationFeedModel>("sp_mst_notificationfeed", new object[] { UserId });
            return result;
        }

    }
}
