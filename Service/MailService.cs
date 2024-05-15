using System.Net;
using System.Net.Mail;

namespace APIContato.Service
{
    public class MailService : IMailService
    {
        private string smtpAddress => "smtp.gmail.com";
        private int portNumber => 587;
        private string emailFromAddress => "thiagoserra1206@gmail.com";
        private string password => "Liliabia2310";

        public void AddEmailsTomailMenssage(MailMessage mailMessage, string[] emails)
        {
            foreach (var email in emails)
            {
                mailMessage.To.Add(email);
            }
        }
        public void SendMail(string emails, string subject, string body, bool isHtml = false)
        {
            using(MailMessage mailMenssage = new MailMessage())
            {
                mailMenssage.From = new MailAddress(emailFromAddress);
                mailMenssage.To.Add(emails);
                mailMenssage.Subject = subject;
                mailMenssage.Body = body;
                mailMenssage.IsBodyHtml = isHtml;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.EnableSsl= true;
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.Send(mailMenssage);
                }
            }
        }

    }
}