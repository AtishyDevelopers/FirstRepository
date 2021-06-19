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
using AppStock.core.Models;

namespace App_Stock.Controllers
{


    [Route("[controller]")]
    [ApiController]

    public class UserMasterController : Controller
    {
        UserMasterService _userService;

        public UserMasterController(UserMasterService userService)
        {
            _userService = userService;
        }


        [HttpGet("getAllUser")]
        public async Task<ActionResult> GetAllUser(int flag)
        {
            try
            {
                var result = await _userService.GetAllUser(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }



        [HttpPost("saveUser")]
        public async Task<IActionResult> SaveUser(UsersMaster objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {
                    if (objItemModel.UserId > 0 & objItemModel.IsDeleted == true)
                        flag = 4;// Delete
                    else if (objItemModel.UserId > 0)
                        flag = 3;//Edit or Update
                    else
                        flag = 2;//Create or insert

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _userService.SaveUser(node.ToString(), flag);
                    return Ok(result);
                }
                return Ok("Something went wrong.");
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }

        }


        [HttpPost("addnewfield")]
        public async Task<IActionResult> AddNewField(UsersMaster objItemModel)
        {
            int flag = 0;
            try
            {
                if (objItemModel != null)
                {

                        flag = 5;//Add new column in mst_user table

                    var model = JsonConvert.SerializeObject(objItemModel);
                    System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                    var result = await _userService.SaveUser(node.ToString(), flag);
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
        //[HttpPost("deleteUser")]
        //public ActionResult DeleteUser(UsersMaster objItemModel)
        //{
        //    int flag = 0;
        //    try
        //    {
        //        if (objItemModel != null)
        //        {
        //            if (objItemModel.UserId > 0 & objItemModel.IsDeleted == true)
        //                flag = 4;// Delete
        //            else if (objItemModel.UserId > 0)
        //                flag = 3;//Edit or Update
        //            else
        //                flag = 2;//Create or insert

        //            var model = JsonConvert.SerializeObject(objItemModel);
        //            System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
        //            var result = await _userService.SaveUser(node.ToString(), flag);
        //            return Ok(result);
        //        }
        //        return Ok("Something went wrong.");
        //    }
        //    catch (Exception ex)
        //    {

        //        return Ok(new { Message = ex });
        //    }
        //}


        [HttpPost("loginUser")]
        public async Task<IActionResult> LoginUser([FromBody] LoginModel model)
        {
            try
            {
                // var node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
                string username = model.Username;
                string password = model.Password;
                var user = await _userService.Login(username, password);

                if (user.Username=="")
                {
                    return BadRequest(new { message = "Username or password is incorrect" });
                }
                   
                else
                {
                    var userDetails = await _userService.UserDetails(username, password);
                    return Ok(userDetails);
                }
                   

               
            }
            catch (Exception ex)
            {

                return Ok(new { ex.Message });
            }
        }




        // POST: ModuleController/Delete/5
        //[HttpPost("deleteUser")]
        //public ActionResult DeleteUser(UsersMaster objItemModel)
        //{
        //    int flag = 0;
        //    try
        //    {
        //        if (objItemModel != null)
        //        {
        //            if (objItemModel.UserId > 0 & objItemModel.IsDeleted == true)
        //                flag = 4;// Delete
        //            else if (objItemModel.UserId > 0)
        //                flag = 3;//Edit or Update
        //            else
        //                flag = 2;//Create or insert

        //            var model = JsonConvert.SerializeObject(objItemModel);
        //            System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");
        //            var result = await _userService.SaveUser(node.ToString(), flag);
        //            return Ok(result);
        //        }
        //        return Ok("Something went wrong.");
        //    }
        //    catch (Exception ex)
        //    {

        //        return Ok(new { Message = ex });
        //    }
        //}
    }
}
