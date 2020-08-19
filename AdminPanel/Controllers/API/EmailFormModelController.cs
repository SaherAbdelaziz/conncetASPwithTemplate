using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AdminPanel.Models;

namespace AdminPanel.Controllers.API
{
    public class EmailFormModelController : ApiController
    {
        [ResponseType(typeof(EmailFormModel))]
        public async Task<IHttpActionResult> PostMail(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.FromEmail));  // replace with valid value 
                message.From = new MailAddress("advbtech2000@gmail.com");  // replace with valid value
                message.Subject = "Eldahan For Web Delivery";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    smtp.UseDefaultCredentials = false;
                    var credential = new NetworkCredential
                    {
                        UserName = "advbtech2000@gmail.com",  // replace with valid value
                        Password = "ABTech123456"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;


                    await smtp.SendMailAsync(message);
                    return Ok(model);

                }
            }

            return Ok(model);

        }
    }
}
