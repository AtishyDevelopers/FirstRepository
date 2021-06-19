using AppStock.core.Models;
using AppStock.Services.Services;
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
    public class MenuFormMapController : ControllerBase
    {
        MenuFormMapService _menuformmapService;

        public MenuFormMapController(MenuFormMapService menuformmapService)
        {
            _menuformmapService = menuformmapService;
        }


        [HttpGet("getAllMenuFormMap")]
        public async Task<ActionResult> GetAllMenuFormMap(int flag)
        {
            try
            {
                var result = await _menuformmapService.GetAllMenuFormMap(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveMenuFormMap")]
        public async Task<IActionResult> SaveMenuFormMap(MenuFormMapModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.MenuFormMapId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.MenuFormMapId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _menuformmapService.SaveMenuFormMap(node.ToString(), flag);
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
