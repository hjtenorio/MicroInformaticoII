using Identity.Domain.AggregatesModel.SenderEmailAggregate;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Identity.Infrastructure.Valtx.SMTP.Client
{
    public class SMTPClient
    {
        public SMTPClient()
        {
        }

        public async Task<bool> SendEmail(EmailComponents email)
        {
            try
            {
                var senderEmail = new MailAddress(email.SenderEmail, email.SenderEmailName);
                var receiverEmail = new MailAddress(email.ReceiverEmail, email.ReceiverEmailName);

                var smtp = new SmtpClient
                {
                    Host = email.Server.Host,
                    Port = email.Server.Port,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = CredentialCache.DefaultNetworkCredentials,
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = email.Subject,
                    Body = email.Body,
                    IsBodyHtml = true
                })
                {
                    await smtp.SendMailAsync(mess);
                    smtp.Dispose();
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}