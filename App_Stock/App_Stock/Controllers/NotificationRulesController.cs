using AppStock.core.Models;
using AppStock.Services;
using AppStock.Services.Services;
using APPSTOCK.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Stock.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NotificationRulesController : Controller
    {
        NotificationRulesService _notificationrulesService;

        public NotificationRulesController(NotificationRulesService notificationrulesService)
        {
            _notificationrulesService = notificationrulesService;
        }


        [HttpGet("getAllProjectRecords")]
        public async Task<ActionResult> GetAllProjectRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllProjectRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpGet("getAllActionRecords")]
        public async Task<ActionResult> GetAllActionRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllActionRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpGet("getAllSubActionRecords")]
        public async Task<ActionResult> GetAllSubActionRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllSubActionRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpGet("getAllEntityTypeRecords")]
        public async Task<ActionResult> GetAllEntityTypeRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllEntityTypeRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpGet("getAllRecipientRecords")]
        public async Task<ActionResult> GetAllgetAllRecipientRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllRecipientRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpGet("getAllChannelRecords")]
        public async Task<ActionResult> GetAllgetAllChannelRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllChannelRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

       


       

        [HttpPost("saveProject")]
        public async Task<IActionResult> SaveProject(ProjectsModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.ProjectId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.ProjectId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveProjectRecords(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        [HttpPost("saveAction")]
        public async Task<IActionResult> SaveAction(NotificationActionsModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.ActionId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.ActionId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveActionRecords(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        [HttpPost("saveSubAction")]
        public async Task<IActionResult> SaveSubAction(NotificationSubActionsModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.SubActionId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.SubActionId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveSubActionRecords(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        [HttpPost("saveEntityType")]
        public async Task<IActionResult> SaveEntityType(NotificationEntityTypeModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.EntityTypeId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.EntityTypeId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveEntityTypeRecords(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        //[HttpPost("saveRecipient")]
        //public async Task<IActionResult> SaveRecipient(NotificationRecipientsModel objItemModel)
        //{
        //    int flag = 0;
        //    try
        //    {
        //        if (objItemModel != null)
        //        {
        //            if (objItemModel.RecipientId > 0 & objItemModel.IsDeleted == true)
        //                flag = 4;// Delete
        //            else if (objItemModel.RecipientId > 0)
        //                flag = 3;//Edit or Update
        //            else
        //                flag = 2;//Create or insert

        //            var model = JsonConvert.SerializeObject(objItemModel);
        //            System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
        //            var result = await _notificationrulesService.SaveRecords(node.ToString(), flag);
        //            return Ok(result);
        //        }
        //        return Ok("Something went wrong.");
        //    }
        //    catch (Exception ex)
        //    {

        //        return Ok(new { Message = ex });
        //    }

        //}

        [HttpPost("saveChannel")]
        public async Task<IActionResult> SaveChannel(NotificationChannelsModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.ChannelId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.ChannelId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveChannelRecords(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }




    }
}
