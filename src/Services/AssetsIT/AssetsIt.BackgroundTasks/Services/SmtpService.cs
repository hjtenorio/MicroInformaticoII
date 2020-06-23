using AssetsIT.BackgroundTasks.Configuration;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.SenderEmailAggregate;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using MimeKit;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AssetsIT.BackgroundTasks.Services
{
    public class SmtpService : ISmtpService
    {
        private IWebHostEnvironment _env;
        private readonly EmailSettings _emailSettings;
        private readonly UrlSpa _urlSpa;
        private readonly ISenderEmailRepository _senderEmailRepository;

        public SmtpService(IWebHostEnvironment env,
            IOptions<EmailSettings> emailSettings,
            IOptions<UrlSpa> urlSpa,
            ISenderEmailRepository senderEmailRepository) {
            _emailSettings = emailSettings.Value;
            _urlSpa = urlSpa.Value;
            _env = env;
            _senderEmailRepository = senderEmailRepository;
        }

        public async Task<bool> SendUserStaffTerminationNotificationEmail(CustomerUserData user, long nroEmployeesTermination) {
            var pathToFile = _env.ContentRootPath + Path.DirectorySeparatorChar.ToString() + "Templates" + Path.DirectorySeparatorChar.ToString() + "Email"
                            + Path.DirectorySeparatorChar.ToString()
                            + "Emai_User_Staff_Termination_Notification_Layout.html";

            var builder = new BodyBuilder();
            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile)) {
                builder.HtmlBody = SourceReader.ReadToEnd();
                SourceReader.Close();
            }

            var url = _urlSpa.ListEmployeeTermination;
            string body = string.Format(builder.HtmlBody,
                        user.FirstName,//{0}
                        nroEmployeesTermination,//{1}
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
            email.Subject = "Microinformático - Colaboradores prontos a cesar";

            email.Body = body;
            var sendEmail = await _senderEmailRepository.SendEmail(email);

            return sendEmail;
        }

        public async Task<bool> SendEmailAdministratorSystem(StringBuilder result, string subject) {
            string body = result.ToString();

            EmailComponents email = new EmailComponents();
            email.Server = new Server() {
                Host = _emailSettings.EmailServerUrl,
                Port = _emailSettings.EmailServerPort
            };
            email.SenderEmail = _emailSettings.ReceiverEmailApi;
            email.SenderEmailName = _emailSettings.ReceiverEmailNameApi;
            email.ReceiverEmail = _emailSettings.ReceiverEmailApi;
            email.ReceiverEmailName = _emailSettings.ReceiverEmailNameApi;
            email.Subject = subject;
            email.Body = body;
            var sendEmail = await _senderEmailRepository.SendEmail(email);

            return sendEmail;
        }
    }
}
