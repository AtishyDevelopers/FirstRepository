using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APPSTOCK.Core.Models;
using AppStock.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStock.Services.Services;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace App_Stock.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        GroupService _groupService;

        public GroupController(GroupService groupService)
        {
            _groupService = groupService;
        }


        [HttpGet("getAllGroup")]
        public async Task<ActionResult> GetAllGroup(int flag)
        {
            try
            {
                var result = await _groupService.GetAllGroup(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveGroup")]
        public async Task<IActionResult> SaveGroup(GroupModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.GroupId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.GroupId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _groupService.SaveGroup(node.ToString(), flag);
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
