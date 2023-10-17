using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;

namespace GIVE_AID.Models
{
    public class EmailService
    {
        public static void SendMail(string to, string subject, string body)
        {
            var from = ConfigurationManager.AppSettings["EmailFrom"];                 //địa chỉ email của mình
            var password = ConfigurationManager.AppSettings["EmailPassword"];         //password email của mình

            var smtpClient = new SmtpClient("smtp.gmail.com", 587);                  // Thay thế smtp.example.com bằng SMTP server của bạn
            smtpClient.Credentials = new NetworkCredential(from, password);
            smtpClient.EnableSsl = true;

            var message = new MailMessage(from, to, subject, body);
            message.IsBodyHtml = true;

            smtpClient.Send(message);
        }
    }
}