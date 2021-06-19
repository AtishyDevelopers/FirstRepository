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
    public class FormsController : ControllerBase
    {
        FormsService _formsService;

        public FormsController(FormsService formsService)
        {
            _formsService = formsService;
        }


        [HttpGet("getAllForms")]
        public async Task<ActionResult> GetAllForms(int flag)
        {
            try
            {
                var result = await _formsService.GetAllForms(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveForms")]
        public async Task<IActionResult> SaveForms(FormsModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.FormID > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.FormID > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _formsService.SaveForms(node.ToString(), flag);
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
