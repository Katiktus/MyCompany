using System.Net;
using System.Net.Mail;

namespace MyCompany.Areas.Admin.Service
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string text)
        {
            using (MailMessage message = new MailMessage("katpog2001@gmail.com", to))
            {
                message.Subject = subject;
                message.Body = text;
                message.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential cred = new NetworkCredential("katpog2001@gmail.com", "Kat0991856303");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = cred;
                    smtp.Port = 587;
                    smtp.Send(message);
                }
            }
        }

    }
}
