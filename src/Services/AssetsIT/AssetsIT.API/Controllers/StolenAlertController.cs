using AssetsIT.API.Configuration;
using AssetsIT.API.Extensions;
using AssetsIT.API.Models.Request;
using AssetsIT.API.Services;
using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.StolenAlertAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AssetsIT.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class StolenAlertController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStolenAlertRepository _stolenAlertrepository;
        private readonly ICustomerUserRepository _customerUserRepository;
        private readonly ISmtpService _smtpService;
        private readonly IOtrsCredencialsService _otrsCredencialsService;
        private readonly IAssetRepository _assetRepository;
        private ConvertFileExtensions _convertFileExtensions;
        private readonly TicketSettings _ticketSettings;
        private readonly ILogger<StolenAlertController> _logger;

        public StolenAlertController(
            ILogger<StolenAlertController> logger,
            IMapper mapper,
            IStolenAlertRepository stolenAlertrepository,
            ICustomerUserRepository customerUserRepository,
            ISmtpService smtpService,
            IOtrsCredencialsService otrsCredencialsService,
            IAssetRepository assetRepository,
            ConvertFileExtensions convertFileExtensions,
            IOptions<TicketSettings> ticketSettings) {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _mapper = mapper;
            _stolenAlertrepository = stolenAlertrepository;
            _customerUserRepository = customerUserRepository;
            _smtpService = smtpService;
            _otrsCredencialsService = otrsCredencialsService;
            _assetRepository = assetRepository;
            _convertFileExtensions = convertFileExtensions;
            _ticketSettings = ticketSettings.Value;
        }

        [HttpPost]
        [ProducesResponseType(typeof(TicketCreateResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddStolenAlert([FromForm] StolenAlertRequest request, [FromForm] IFormFile policeAlertFile, [FromForm] IFormFile affidavitFile) {
            try {
                var user = await _customerUserRepository.GetCustomerUserByDni(request.UserDni);
                if (user == null) {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }

                StolenAlert stolenAlert = new StolenAlert {
                    UserCip = user.CustomerId,
                    OtrsServiceId = _ticketSettings.StolenAlertServiceID,
                    Asset = await _assetRepository.GetAssetById(request.AssetId),
                    PoliceReport = _mapper.Map<PoliceReport>(_convertFileExtensions.ConvertFileToBase64(policeAlertFile)),
                    Affidavit = _mapper.Map<Affidavit>(_convertFileExtensions.ConvertFileToBase64(affidavitFile))
                };
                var result = _stolenAlertrepository.AddStolenAlert(
                        _mapper.Map<TicketCredencials>(_otrsCredencialsService.GetOtrsCredencials()),
                        stolenAlert);

                if (result.TicketID != null) {
                    await _assetRepository.UpdateAssetByStolen(request.AssetId);
                    var sendMail = await _smtpService.SendEmailCreateTicket(user, result.TicketNumber);

                    return StatusCode(StatusCodes.Status201Created, new { Result = result, EmailSend = false, Status = 1 });
                } else {
                    return StatusCode(StatusCodes.Status400BadRequest, new { Result = result, EmailSend = false, Status = 0 });
                }
            } catch (Exception e) {
                _logger.LogError(e, "Stolen Alert Controller Error");
                return StatusCode(StatusCodes.Status500InternalServerError, new { StatusName = e.Message, Message = "Ocurrió un problema al guardar la información.", EmailSend = false, Status = 0 });
            }
        }
    }
}