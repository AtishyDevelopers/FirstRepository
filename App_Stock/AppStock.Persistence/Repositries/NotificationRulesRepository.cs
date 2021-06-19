using AppStock.core.Models;
using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppStock.Persistence.Repositries
{
   public class NotificationRulesRepository
    {
        private IRepository _repository;
        public NotificationRulesRepository(IRepository repository)
        {
            _repository = repository;
        }

        #region Project
        public async Task<List<ProjectsModel>> GetAllProjectRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ProjectsModel>("sp_mst_Project", new object[] { node.ToString(), flag });
            return result;
        }

       

        public async Task<List<ResponseModel>> SaveProjectRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_Project", new object[] { node.ToString(), flag });
            return result;
        }

        #endregion Project


        #region Action
        public async Task<List<NotificationActionsModel>> GetAllActionRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationActionsModel>("sp_mst_NotificationAction", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> SaveActionRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_NotificationAction", new object[] { node.ToString(), flag });
            return result;
        }

        #endregion Action

        #region SubAction

        public async Task<List<NotificationSubActionsModel>> GetAllSubActionRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationSubActionsModel>("sp_mst_NotificationSubAction", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> SaveSubActionRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_NotificationSubAction", new object[] { node.ToString(), flag });
            return result;
        }

        #endregion SubAction

        #region Entity

        public async Task<List<NotificationEntityTypeModel>> GetAllEntityTypeRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationEntityTypeModel>("sp_mst_NotificationEntityType", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> SaveEntityTypeRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_NotificationEntityType", new object[] { node.ToString(), flag });
            return result;
        }

        #endregion Entity


        #region Recipient
        public async Task<List<NotificationRecipientsModel>> GetAllRecipientRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationRecipientsModel>("sp_mst_Notification", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<NotificationChannelsModel>> GetAllChannelRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<NotificationChannelsModel>("sp_mst_NotificationChannel", new object[] { node.ToString(), flag });
            return result;
        }

        #endregion Recipient

        #region Channel
        public async Task<List<ResponseModel>> SaveChannelRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_NotificationChannel", new object[] { node.ToString(), flag });
            return result;
        }

        public async Task<List<ResponseModel>> SaveRecords(string node, int flag)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("sp_mst_Notification", new object[] { node.ToString(), flag });
            return result;
        }

        #endregion Channel

    }
}
