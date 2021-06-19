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
    public class UserReportController : ControllerBase
    {
        UserReportService _UserReportService;

        public UserReportController(UserReportService UserReportService)
        {
            _UserReportService = UserReportService;
        }


        [HttpGet("getAllUserReport")]
        public async Task<ActionResult> GetAllUserReport(int flag)
        {
            try
            {
                var result = await _UserReportService.GetAllUserReport(string.Empty, flag);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }

    }
}
