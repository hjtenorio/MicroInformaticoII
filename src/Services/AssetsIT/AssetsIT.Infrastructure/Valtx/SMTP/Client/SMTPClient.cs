using AssetsIT.Domain.AggregatesModel.SenderEmailAggregate;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AssetsIT.Infrastructure.Valtx.SMTP.Client
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

        public async Task<bool> SendEmailMultipleReceivers(EmailComponetsMultipleReceivers email)
        {
            try
            {
                var senderEmail = new MailAddress(email.SenderEmail, email.SenderEmailName);

                var smtp = new SmtpClient
                {
                    Host = email.Server.Host,
                    Port = email.Server.Port,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = CredentialCache.DefaultNetworkCredentials,
                };

                using (var mess = new MailMessage())
                {
                    mess.From = senderEmail;
                    foreach (string emailReceivers in email.ReceiverEmail)
                    {
                        mess.To.Add(emailReceivers);
                    };
                    mess.Subject = email.Subject;
                    mess.Body = email.Body;
                    mess.IsBodyHtml = true;

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