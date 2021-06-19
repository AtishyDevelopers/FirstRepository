using AppStock.Services;
using APPSTOCK.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonConvert = Newtonsoft.Json.JsonConvert;


namespace App_Stock.Controllers
{


    [Route("[controller]")]
    [ApiController]

    public class ModuleController : Controller
    {

        ModuleService _moduleService;

        public ModuleController(ModuleService moduleService)
        {
            _moduleService = moduleService;
        }


        [HttpGet("getAllModule")]
        public async Task<ActionResult> GetAllModule(int flag)
        {
            try
            {
                var result = await _moduleService.GetAllModule(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveModule")]
        public async Task<IActionResult> SaveModule(ModulesModel objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.ModuleId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.ModuleId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _moduleService.SaveModule(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }


      
        // POST: ModuleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
