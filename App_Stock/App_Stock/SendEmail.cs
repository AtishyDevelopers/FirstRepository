using AppStock.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using AppStock.core.Models;


namespace App_Stock
{
    public class SendEmail
    {
        private static string Pass, FromEmailid, HostAdd;
        private static int Port;
        // static BL.Master.Mailer objMail = new BL.Master.Mailer();
        private static string smtpServer, fromEmailid, password;
        private static int port;
    
       


        EmailConfigService _emailConfigService;

        public string Email_Without_Attachment(string ToEmail, string Subj, string Message)
        {
            try
            {

                //Reading sender Email credential from web.config file
                //HostAdd = ConfigurationManager.AppSettings["Host"].ToString();
                //FromEmailid = ConfigurationManager.AppSettings["FromMail"].ToString();
                //Pass = ConfigurationManager.AppSettings["Password"].ToString();
                //Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
              //  maildetails();
                HostAdd = smtpServer;
                FromEmailid = fromEmailid.ToString();
                Pass = password.ToString();
                Port = Convert.ToInt32(port);

                //creating the object of MailMessage
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(FromEmailid); //From Email Id
                mailMessage.Subject = Subj; //Subject of Email
                mailMessage.Body = Message; //body or message of Email
                mailMessage.IsBodyHtml = true;
                //Adding Multiple recipient email id logic
                string[] Multi = ToEmail.Split(','); //spiliting input Email id string with comma(,)
                foreach (string Multiemailid in Multi)
                {
                    mailMessage.To.Add(new MailAddress(Multiemailid)); //adding multi reciver's Email Id
                }
                SmtpClient smtp = new SmtpClient(); // creating object of smptpclient
                smtp.Host = HostAdd; //host of emailaddress for example smtp.gmail.com etc

                //network and security related credentials
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = mailMessage.From.Address;
                NetworkCred.Password = Pass;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.Port = Port;
                smtp.Send(mailMessage); //sending Email
                return ("Success");

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                //ExceptionLogInsert.SaveException(ex);
                return ("Error");
            }
        }

       
       //public static  void maildetails()
       // {
           
       //     var result await _emailConfigService.GetMailDetails(string.Empty, 0);
       //    // var MailDetails =await _emailConfigService.GetMailDetails(string.Empty, 0);
       //     smtpServer = result.First().smtpServer;
       //    // smtpServer = MailDetails.smtpServer.ToString();
       //     fromEmailid = result.First().FromEmailid.ToString();
       //     password = result.First().password.ToString();
       //     port = Convert.ToInt32(result.First().PortNumber);

       // }

        
        public static string SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
        {

            try
            {

                //MailMessage msg = new MailMessage();

                //msg.From = new MailAddress("reports@maxidoo.in");
                //msg.To.Add(recepientEmail);
                //msg.Subject = subject;
                //msg.Body = body;
                //msg.Priority = MailPriority.High;

                //SmtpClient client = new SmtpClient();

                //client.Credentials = new NetworkCredential("reports@maxidoo.in", "Atishay@123", "smtp.gmail.com");
                //client.Host = "smtp.gmail.com";
                //client.Port = 587;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.EnableSsl = true;
                //client.UseDefaultCredentials = false;

                //client.Send(msg);


                using (MailMessage mailMessage = new MailMessage())
                {
                   // maildetails();
                    //HostAdd = smtpServer;
                    //FromEmailid = fromEmailid.ToString();
                    //Pass = password.ToString();
                    //Port = Convert.ToInt32(port);

                    mailMessage.From = new MailAddress("reports@maxidoo.in");//new MailAddress(ConfigurationManager.AppSettings["UserName"]);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.To.Add(new MailAddress(recepientEmail));
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";//ConfigurationManager.AppSettings["Host"];
                    smtp.EnableSsl = true;//Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
                    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                    NetworkCred.UserName = "reports@maxidoo.in";//ConfigurationManager.AppSettings["UserName"];
                    NetworkCred.Password = "Atishay@123";// ConfigurationManager.AppSettings["Password"];
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;//int.Parse(ConfigurationManager.AppSettings["Port"]);
                    smtp.Send(mailMessage);
                    return ("Success");
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                //ExceptionLogInsert.SaveException(ex);
                return ("Error");
            }
        }
    }
}
