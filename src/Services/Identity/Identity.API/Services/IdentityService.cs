using Identity.API.Configuration;
using Identity.Domain.AggregatesModel.ConstantsAggregate;
using Identity.Domain.AggregatesModel.JwtTokenAggregate;
using Identity.Domain.AggregatesModel.SenderEmailAggregate;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Valtx.RAIS.WebService;

namespace Identity.API.Services
{
    public class IdentityService : IIdentityService
    {
        private IWebHostEnvironment _env;
        private readonly AppSettings _appSettings;
        private readonly ResetPasswordSettings _resetPasswordSettings;
        private readonly EmailSettings _emailSettings;
        private readonly IJwtTokenRepository _jwtTokenRepository;
        private readonly ISenderEmailRepository _senderEmailRepository;

        public IdentityService(
            IWebHostEnvironment env, 
            IOptions<AppSettings> appSettings,
            IOptions<ResetPasswordSettings> resetPasswordSettings,
            IOptions<EmailSettings> emailSettings,
            IJwtTokenRepository jwtTokenRepository,
            ISenderEmailRepository senderEmailRepository) 
        {
            _appSettings = appSettings.Value;
            _resetPasswordSettings = resetPasswordSettings.Value;
            _emailSettings = emailSettings.Value;
            _jwtTokenRepository = jwtTokenRepository;
            _env = env;
            _senderEmailRepository = senderEmailRepository;
        }

        public async Task<bool> SendEmailForgotPassword(Usuario user, string claimName, string claimLogin)
        {
            var resetToken = _jwtTokenRepository.CreateJwtToken(_appSettings.Secret, claimName, claimLogin);
            var pathToFile = _env.ContentRootPath + Path.DirectorySeparatorChar.ToString() + "Templates" + Path.DirectorySeparatorChar.ToString() + "Email"
                            + Path.DirectorySeparatorChar.ToString()
                            + "Email_Forgot_Password_Layout.html";

            var builder = new BodyBuilder();
            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
            {
                builder.HtmlBody = SourceReader.ReadToEnd();
                SourceReader.Close();
            }

            var url = _resetPasswordSettings.WebBaseUrl + resetToken;
            string body = string.Format(builder.HtmlBody,
                        user.Nombre,//{0}
                        url);//{1}

            EmailComponents email = new EmailComponents();
            email.Server = new Server()
            {
                Host = _emailSettings.EmailServerUrl,
                Port = _emailSettings.EmailServerPort
            };
            email.SenderEmail = _emailSettings.ReceiverEmailApi;
            email.SenderEmailName = _emailSettings.ReceiverEmailNameApi;
            email.ReceiverEmail = user.Email;
            email.ReceiverEmailName = user.Nombre + " " + user.Apellido;
            email.Subject = Message.IdentityForgetPassEmailSubject;
            email.Body = body;
            var sendEmail = await _senderEmailRepository.SendEmail(email);

            return sendEmail;
        }
    }
}
