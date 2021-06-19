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
   public class NotificationFeedService
    {
        private NotificationFeedRepository _NotificationFeedRepository;

        public NotificationFeedService(NotificationFeedRepository NotificationFeedRepository)
        {
            _NotificationFeedRepository = NotificationFeedRepository;
        }
        public async Task<List<NotificationFeedModel>> GetNotificationFeed(string UserId)
        {
            var result = await _NotificationFeedRepository.GetNotificationFeed(UserId);
            return result;
        }
    }
}
