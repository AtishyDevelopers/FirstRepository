using AppStock.core.Models;
using AppStock.Services;
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
    public class RulesNotificationController : Controller
    {
        RulesNotificationService _notificationrulesService;

        public RulesNotificationController(RulesNotificationService notificationrulesService)
        {
            _notificationrulesService = notificationrulesService;
        }

        [HttpGet("getAllNotificationRulesRecords")]
        public async Task<ActionResult> GetAllNotificationRulesRecords()
        {
            try
            {
                int flag = 1;
                var result = await _notificationrulesService.GetAllNotificationRulesRecords(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpPost("saveNotificationRules")]
        public async Task<IActionResult> SaveNotificationRules(NotificationRulesModel objItemModel)
        {
            int flag = 2;

            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.SubActionList.Count > 0)
                    {
                        NotificationRulesModel objNotification = new NotificationRulesModel();
                        foreach (var i in objItemModel.SubActionList)
                        {
                            objNotification.SubActionId = i.SubActionId;
                            foreach (var e in objItemModel.EntityTypeList)
                            {
                                objNotification.EntityTypeId = e.EntityTypeId;

                                foreach (var r in objItemModel.RoleList)
                                {
                                    objNotification.RoleId = (int)r.RoleId;

                                    foreach (var c in objItemModel.ChannelList)
                                    {
                                        objNotification.ChannelId = c.ChannelId;
                                        objNotification.ProjectId = objItemModel.ProjectId;
                                        objNotification.ActionId = objItemModel.ActionId;
                                        objNotification.CreatedById = objItemModel.CreatedById;
                                        objNotification.CreatedByIP = objItemModel.CreatedByIP;
                                        var model = JsonConvert.SerializeObject(objNotification);
                                        System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                                        var result = await _notificationrulesService.SaveNotificationRules(node.ToString(), flag);
                                    }
                                }
                            }
                        }
                    }
                    return Ok("Record added successfully ");
                }

                ////if (objItemModel != null)
                ////{
                ////    if (objItemModel.RulesId > 0 & objItemModel.IsDeleted == true)
                ////        flag = 10;// Delete
                ////    else if (objItemModel.RulesId > 0)
                ////        flag = 9;//Edit or Update
                ////    else
                ////        flag = 8;//Create or insert

                ////    var model = JsonConvert.SerializeObject(objItemModel);
                ////    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                ////    var result = await _notificationrulesService.SaveRecords(node.ToString(), flag);
                ////    return Ok(result);
                ////}
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        [HttpPost("updateNotificationRules")]
        public async Task<IActionResult> UpdateNotificationRules(NotificationRulesModel objItemModel)
        {
            int flag = 3;

            try
            {



                if (objItemModel != null)
                {

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveNotificationRules(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");

            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        [HttpPost("deleteNotificationRules")]
        public async Task<IActionResult> DeleteNotificationRules(NotificationRulesModel objItemModel)
        {
            int flag = 4;

            try
            {



                if (objItemModel != null)
                {

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _notificationrulesService.SaveNotificationRules(node.ToString(), flag);
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
