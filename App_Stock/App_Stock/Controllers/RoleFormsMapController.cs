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
    public class RoleFormsMapController : ControllerBase
    {
        RoleFormsMapService _roleformsmapService;

        public RoleFormsMapController(RoleFormsMapService roleformsmapService)
        {
            _roleformsmapService = roleformsmapService;
        }


        [HttpGet("getAllRoleFormsMap")]
        public async Task<ActionResult> GetAllRoleFormsMap(int flag)
        {
            try
            {
                var result = await _roleformsmapService.GetAllRoleFormsMap(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveRoleFormsMap")]
        public async Task<IActionResult> SaveRoleFormsMap(RoleFormsMapModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.RoleFormMapId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.RoleFormMapId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _roleformsmapService.SaveRoleFormsMap(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }

        [HttpGet("getAllFormpath")]
        public async Task<ActionResult> GetAllFormpath(int flag)
        {
            try
            {
                var result = await _roleformsmapService.GetAllFormpath(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

    }
}
