using AppStock.core.Models;
using AppStock.Services.Services;
using APPSTOCK.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace App_Stock.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleModuleMapController : ControllerBase
    {
        RoleModuleMapService _RoleModuleMapService;

        public RoleModuleMapController(RoleModuleMapService RoleModuleMapService)
        {
            _RoleModuleMapService = RoleModuleMapService;
        }


        [HttpGet("getAllRoleModuleMap")]
        public async Task<ActionResult> GetAllRoleModuleMap(int flag)
        {
            try
            {
                var result = await _RoleModuleMapService.GetAllRoleModuleMap(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveRoleModuleMap")]
        public async Task<IActionResult> SaveRoleModuleMap(RoleModuleMapModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.RoleModuleMapId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.RoleModuleMapId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _RoleModuleMapService.SaveRoleModuleMap(node.ToString(), flag);
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
