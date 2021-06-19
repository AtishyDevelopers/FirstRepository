using AppStock.Services;
using AppStock.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace App_Stock.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class SendNotificationController : Controller
    {
        SendMailService _sendMailService;
       

        private readonly IConfiguration _config;

       
        public SendNotificationController(SendMailService sendMailService)
        {
            _sendMailService = sendMailService;
        }

   

        [HttpGet("getsendNotification")]
        public async Task<ActionResult> GetSendNotification()
        {
            try
            {
               

              //  string dbConn2 = configuration.GetValue<string>("MailSettings:FromMail");

                //string frommail = configuration.GetSection("MailSettings").GetSection("FromMail").Value;
                //string Password = configuration.GetSection("MailSettings").GetSection("Password").Value;
                //string Host = configuration.GetSection("MailSettings").GetSection("Host").Value;
                //string Port = configuration.GetSection("MailSettings").GetSection("Port").Value;

                string Msg = "";
                var result = await _sendMailService.GetAllNotificationRulesRecords(string.Empty, 1);
                if(result.Count()>0)
                {
                    foreach (var i in result)
                    {
                        int RoleId = i.RoleId;
                        var users = await _sendMailService.GetUserDetails(Convert.ToString(RoleId));
                        if (users.Count()>0)
                        {
                            foreach(var u in users)
                            {
                                string UserName = u.UserName;
                                string FirstName = u.FirstName;
                                string LastName = u.LastName;
                                string Email = u.EmailAddress;

                                string Mybody = " Hi" + " " + FirstName + " " + LastName + " " + "," +" Here are some updates for you."+ "<br /><br />"
                                         + " setup automatic notifications using slack webhooks. " + "<br /><br />"
                                         + i.ActionName+" --> "+i.SubActionName + "<br />"                                        
                                         + "<br /><br />"
                                         + " Note: This is a system generated email so please do not reply to this. Please contact AppStock team Head for further clarifications if required." + "<br /><br />"
                                         + " Regards," + "<br /><br />" + " Team " + "AppStock Team" + ".";

                               Msg =  SendEmail.SendHtmlFormattedEmail(u.EmailAddress, "Rules Notification", Mybody);
                            }
                        }
                    }
                }
                return Ok(Msg);
            }
            catch (Exception ex)
            {

                return Ok(new { Message = ex });
            }
        }
    }
}
