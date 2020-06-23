using Identity.API.Models.Request;
using Identity.API.Services;
using Identity.Infrastructure.Valtx.RAIS.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Identity.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IdentityController : Controller
    {
        private readonly RAISClient _RAISHttpClient;
        private readonly ITokenProviderService _tokenProviderService;
        private readonly IIdentityService _identityService;
        private readonly ILogger<IdentityController> _logger;

        public IdentityController(
            RAISClient client,
            ITokenProviderService tokenProviderService,
            IIdentityService identityService,
            ILogger<IdentityController> logger) {
            _RAISHttpClient = client;
            _tokenProviderService = tokenProviderService;
            _identityService = identityService;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        [Route("Authenticate")]
        public async Task<IActionResult> Authenticate([FromForm] IdentityTokenRequest request) {
            int idSistema = 3;
            var response = await _RAISHttpClient.Authenticate(request.Username, request.Password, idSistema);

            if (!response.Success) {
                var errorMessage = response.Message;
                return new JsonResult(errorMessage) {
                    StatusCode = StatusCodes.Status401Unauthorized
                };
            }

            var authToken = await _tokenProviderService.GetToken(request);

            if (authToken.Error != null) {
                return new JsonResult(authToken) {
                    StatusCode = StatusCodes.Status401Unauthorized
                };
            }

            var userId = response.Data.idUsuario;
            var menu = await _RAISHttpClient.GetMenuStructure(userId, idSistema);

            return Ok(new {
                authToken,
                response,
                menu
            });
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(string nroDni) {
            try {
                int idSistema = 3;
                var user = await _RAISHttpClient.GetUserAuthenticated(nroDni, idSistema);
                if (user == null) {
                    var errorMessage = "Usuario no existe";
                    return new JsonResult(errorMessage) {
                        StatusCode = StatusCodes.Status404NotFound
                    };
                }
                var sendEmail = await _identityService.SendEmailForgotPassword(user, ClaimTypes.Name, user.Login);

                if (sendEmail) {
                    return StatusCode(StatusCodes.Status200OK, new { Message = "Correo enviado a " + user.Email, EmailSend = sendEmail, Status = 1 });
                } else {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable, new { Message = "Correo no enviado por problemas de conexión ", EmailSend = sendEmail, Status = 0 });
                }
            } catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError, new { StatusName = e.Message, Message = "Ocurrió un problema al recuperar la contraseña.", EmailSend = false, Status = 0 });
            }
        }

        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword(string token, string newPassword) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenReaded = (tokenHandler.ReadToken(token) as JwtSecurityToken).Claims;
            int idSistema = 3;
            var username = tokenReaded.First(claim => claim.Type == "unique_name").Value;
            var user = await _RAISHttpClient.GetUserAuthenticated(username, idSistema);
            var response = await _RAISHttpClient.ChangePassword(user.Login, newPassword);
            if (response == null) {
                return StatusCode(StatusCodes.Status200OK, new { Message = "Se ha modificado con éxito su contraseña.", Status = 1 });
            }
            return StatusCode(StatusCodes.Status400BadRequest, new { Message = response.Message, Status = 0 });
        }
    }
}