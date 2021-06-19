
using APPSTOCK.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonConvert = Newtonsoft.Json.JsonConvert;
using AppStock.core.Models;
using AppStock.Services.Services;

namespace App_Stock.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddColumnController : ControllerBase
    {
        AddColumnService _AddColumnService;

        public AddColumnController(AddColumnService AddColumnService)
        {
            _AddColumnService = AddColumnService;
        }


        [HttpGet("getAllTableName")]
        public async Task<ActionResult> GetAllTableName(int flag)
        {
            try
            {
                var result = await _AddColumnService.GetAllTableName(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

        [HttpPost("addnewfield")]
        public async Task<IActionResult> AddNewField(AddColumnModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {

                    flag = 5;//Add new column in mst_user table

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _AddColumnService.SaveColumn(node.ToString(), flag);
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
