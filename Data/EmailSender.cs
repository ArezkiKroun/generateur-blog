
    using Microsoft.AspNetCore.Identity.UI.Services;
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;

    namespace Projet_.Net.Data
    {
        public class EmailSender : IEmailSender
        {
            public EmailSender()
            {

            }

            public async Task SendEmailAsync(string email, string subject, string htmlMessage)
            {
                string fromMail = "krounarezki@gmail.com";
                //string fromPassword = "[APPPASSWORD]";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = subject;
                message.To.Add(new MailAddress(email));
                message.Body = "<html><body> " + htmlMessage + " </body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("localhost")
                {
                    Port = 1025,
                    //Credentials = new NetworkCredential(fromMail, fromPassword),
                    //EnableSsl = true,
                };
                smtpClient.Send(message);
            }

        }
    }

