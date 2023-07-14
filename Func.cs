using System.Net;
using System.Net.Mail;

namespace SmtpClient_Library
{
    public class Func
    {
        static public void Send(SendInfo info)
        {
            var mail = info.mail;
            var client = info.client;

            using SmtpClient smtp_client = new()
            {
                Host = client.Host,
                Port = client.Port,
                EnableSsl = client.EnableSsl,

                Credentials = new NetworkCredential(client.UserName, client.Password),
            };

            if (mail.From is null) throw new Exception("mail.From is null");
            using MailMessage message = new()
            {
                Subject = mail.Subject,
                Body = mail.Body,
                IsBodyHtml = mail.IsBodyHtml,
                From = new MailAddress(mail.From.Address, mail.From.DisplayName)
            };

            foreach (var addr in mail.To) message.To.Add(addr);
            foreach (var addr in mail.CC) message.CC.Add(addr);
            foreach (var addr in mail.Bcc) message.Bcc.Add(addr);

            smtp_client.Send(message);
        }
    }
}
