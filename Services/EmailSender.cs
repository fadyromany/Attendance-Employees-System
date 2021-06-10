using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace Attendance_Employees_System.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender()
        {

        }
        
        public async Task SendEmailAsync(string email, string subject,string password)
        {
            string fromMail = "Please add Your mail";
            string fromPassword = "please add your password";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Attendance Employee credentials";
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body> " + $"Dears, <br> Kindly find attached credentials,Username= {email}, Password= {password} please dont share it with any body <br> Thanks, <br> System Administrator" + " </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
    }
}
