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
    public class RoleController : ControllerBase
    {
        RoleService _roleService;

        public RoleController(RoleService roleService)
        {
            _roleService = roleService;
        }


        [HttpGet("getAllRole")]
        public async Task<ActionResult> GetAllRole(int flag)
        {
            try
            {
                var result = await _roleService.GetAllRole(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveRole")]
        public async Task<IActionResult> SaveRole(RoleModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.RoleId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.RoleId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _roleService.SaveRole(node.ToString(), flag);
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
