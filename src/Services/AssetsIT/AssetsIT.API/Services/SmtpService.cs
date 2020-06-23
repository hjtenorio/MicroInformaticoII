using AssetsIT.API.Configuration;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.SenderEmailAggregate;
using AssetsIT.Infrastructure.Valtx.OTRS;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AssetsIT.API.Services
{
    public class SmtpService : ISmtpService
    {
        private IWebHostEnvironment _env;
        private readonly EmailSettings _emailSettings;
        private readonly TicketSettings _ticketSettings;
        private readonly ISenderEmailRepository _senderEmailRepository;
        private readonly OTRSOptions _OTRSOptions;

        public SmtpService(IWebHostEnvironment env,

            IOptions<EmailSettings> emailSettings,
            IOptions<TicketSettings> ticketSettings,
            IOptionsMonitor<OTRSOptions> OTRSOptions,
            ISenderEmailRepository senderEmailRepository) {
            _emailSettings = emailSettings.Value;
            _ticketSettings = ticketSettings.Value;
            _OTRSOptions = OTRSOptions.CurrentValue;
            _env = env;
            _senderEmailRepository = senderEmailRepository;
        }

        public async Task<bool> SendEmailCreateTicket(CustomerUserData user, string nroTicket) {
            var pathToFile = _env.ContentRootPath + Path.DirectorySeparatorChar.ToString() + "Templates" + Path.DirectorySeparatorChar.ToString() + "Email"
                            + Path.DirectorySeparatorChar.ToString()
                            + "Email_Create_Ticket_Layout.html";

            var builder = new BodyBuilder();
            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile)) {
                builder.HtmlBody = SourceReader.ReadToEnd();
                SourceReader.Close();
            }

            var url = _ticketSettings.TicketDetailUrl + nroTicket;
            string body = string.Format(builder.HtmlBody,
                        user.FirstName,//{0}
                        nroTicket,//{1}
                        url);//{2}

            EmailComponents email = new EmailComponents();
            email.Server = new Server() {
                Host = _emailSettings.EmailServerUrl,
                Port = _emailSettings.EmailServerPort
            };
            email.SenderEmail = _emailSettings.ReceiverEmailApi;
            email.SenderEmailName = _emailSettings.ReceiverEmailNameApi;
            email.ReceiverEmail = user.Email;
            email.ReceiverEmailName = user.FirstName + " " + user.LastName;
            email.Subject = _OTRSOptions.StoleAlertTicketEmailSubject + " " + nroTicket;
            email.Body = body;
            var sendEmail = await _senderEmailRepository.SendEmail(email);

            return sendEmail;
        }

        public async Task<bool> SendEmailCreateTicketMultipleReceivers(List<CustomerUserData> user, string nroTicket) {
            string body = "";

            EmailComponetsMultipleReceivers email = new EmailComponetsMultipleReceivers();
            email.Server = new Server() {
                Host = _emailSettings.EmailServerUrl,
                Port = _emailSettings.EmailServerPort
            };
            email.SenderEmail = _emailSettings.ReceiverEmailApi;
            email.SenderEmailName = _emailSettings.ReceiverEmailNameApi;
            //email.ReceiverEmail = new List<string>();
            foreach (CustomerUserData emailUsers in user) {
                email.ReceiverEmail.Add(emailUsers.Email);
            }
            email.Subject = _OTRSOptions.StoleAlertTicketEmailSubject + " " + nroTicket;
            email.Body = body;
            var sendEmail = await _senderEmailRepository.SendEmailMultipleReceivers(email);

            return sendEmail;
        }

        public async Task<bool> SendUserStaffTerminationNotificationEmail(CustomerUserData user, int nroEmployeesTermination) {
            var pathToFile = _env.ContentRootPath + Path.DirectorySeparatorChar.ToString() + "Templates" + Path.DirectorySeparatorChar.ToString() + "Email"
                            + Path.DirectorySeparatorChar.ToString()
                            + "Emai_User_Staff_Termination_Notification_Layout.html";

            var builder = new BodyBuilder();
            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile)) {
                builder.HtmlBody = SourceReader.ReadToEnd();
                SourceReader.Close();
            }

            var url = _ticketSettings.TicketDetailUrl;
            string body = string.Format(builder.HtmlBody,
                        user.FirstName,//{0}
                        nroEmployeesTermination);//{1}

            EmailComponents email = new EmailComponents();
            email.Server = new Server() {
                Host = _emailSettings.EmailServerUrl,
                Port = _emailSettings.EmailServerPort
            };
            email.SenderEmail = _emailSettings.ReceiverEmailApi;
            email.SenderEmailName = _emailSettings.ReceiverEmailNameApi;
            email.ReceiverEmail = user.Email;
            email.ReceiverEmailName = user.FirstName + " " + user.LastName;
            email.Subject = _OTRSOptions.UserStaffTerminationNotification;
            email.Body = body;
            var sendEmail = await _senderEmailRepository.SendEmail(email);

            return sendEmail;
        }
    }
}
