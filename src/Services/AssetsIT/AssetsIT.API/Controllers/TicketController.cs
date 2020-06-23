using AssetsIT.API.Configuration;
using AssetsIT.API.Extensions;
using AssetsIT.API.Models.Request;
using AssetsIT.API.Services;
using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AssetsIT.API.Controllers
{
    [Route("api/v1/[controller]")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerUserRepository _customerUserRepository;
        private readonly ISmtpService _smtpService;
        private readonly IAssetRepository _assetRepository;
        private readonly IOtrsCredencialsService _otrsCredencialsService;
        private readonly ITicketRepository _ticketRepository;
        private ConvertFileExtensions _convertFileExtensions;
        private readonly TicketSettings _ticketSettings;

        public TicketController(IMapper mapper,
            ICustomerUserRepository customerUserRepository,
            ISmtpService smtpService,
            IAssetRepository assetRepository,
            IOtrsCredencialsService otrsCredencialsService,
            ITicketRepository ticketRepository,
            ConvertFileExtensions convertFileExtensions,
            IOptions<TicketSettings> ticketSettings) {
            _mapper = mapper;
            _customerUserRepository = customerUserRepository;
            _smtpService = smtpService;
            _assetRepository = assetRepository;
            _otrsCredencialsService = otrsCredencialsService;
            _ticketRepository = ticketRepository;
            _convertFileExtensions = convertFileExtensions;
            _ticketSettings = ticketSettings.Value;
        }

        [Route("incidence")]
        [HttpPost]
        [ProducesResponseType(typeof(TicketCreateResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddIncidence([FromForm] IncidenceCreateRequest request, [FromForm] List<IFormFile> attachments) {
            try {
                var user = await _customerUserRepository.GetCustomerUserByDni(request.UserDni);
                if (user == null) {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }

                TicketIncidenceCreate ticket = new TicketIncidenceCreate {
                    UserCip = user.CustomerId,
                    OtrsServiceId = request.OtrsServiceID,
                    Description = request.Description,
                    Asset = await _assetRepository.GetAssetById(request.AssetId),
                    Attachments = _mapper.Map<List<TicketAttachments>>(_convertFileExtensions.ListConvertFileToBase64(attachments))
                };
                var result = _ticketRepository.AddTicketIncidenceOtrs(
                        _mapper.Map<TicketCredencials>(_otrsCredencialsService.GetOtrsCredencials()),
                        ticket);

                if (result.TicketID != null) {
                    var sendMail = await _smtpService.SendEmailCreateTicket(user, result.TicketNumber);

                    return StatusCode(StatusCodes.Status201Created, new { Result = result, EmailSend = sendMail, Status = 1 });
                } else {
                    return StatusCode(StatusCodes.Status400BadRequest, new { Result = result, EmailSend = false, Status = 0 });
                }
            } catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError, new { StatusName = e.Message, Message = "Ocurrió un problema al guardar la información.", EmailSend = false, Status = 0 });
            }
        }

        [Route("incidence")]
        [HttpPut]
        [ProducesResponseType(typeof(TicketCreateResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateIncidence([FromForm] IncidenceUpdateRequest request, [FromForm] List<IFormFile> attachments) {
            try {
                var ticketData = await _ticketRepository.GetTicketDetailByNroTicket(request.NroTicket);

                if (ticketData == null) {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }

                TicketIncidenceCreate ticket = new TicketIncidenceCreate {
                    TicketId = ticketData.Id,
                    Description = request.Description,
                    Attachments = _mapper.Map<List<TicketAttachments>>(_convertFileExtensions.ListConvertFileToBase64(attachments))
                };

                var result = _ticketRepository.UpdateTicketOtrs(
                        _mapper.Map<TicketCredencials>(_otrsCredencialsService.GetOtrsCredencials()),
                        ticket);

                if (result.TicketID != null) {
                    return StatusCode(StatusCodes.Status201Created, new { Result = result, EmailSend = false, Status = 1 });
                } else {
                    return StatusCode(StatusCodes.Status400BadRequest, new { Result = result, EmailSend = false, Status = 0 });
                }
            } catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError, new { StatusName = e.Message, Message = "Ocurrió un problema al guardar la información.", EmailSend = false, Status = 0 });
            }
        }

        [Route("norenew")]
        [HttpPost]
        [ProducesResponseType(typeof(TicketCreateResponse), (int)HttpStatusCode.OK)]
        public async Task<TicketCreateResponse> AddRequerimentNoRenew([FromForm] string customerId, [FromForm] string assetId, [FromForm] List<IFormFile> attachments) {
            try {
                var user = await _customerUserRepository.GetCustomerUserByCip(customerId);
                var asset = await _assetRepository.GetAssetById(assetId);

                if (user == null || asset == null) {
                    return new TicketCreateResponse();
                }

                TicketIncidenceCreate ticket = new TicketIncidenceCreate {
                    UserCip = user.CustomerId,
                    OtrsServiceId = _ticketSettings.AssetReturnTerminationServiceID,
                    Description = $"Apellidos: {user.LastName}\n" +
                                $"Nombres: {user.FirstName}\n" +
                                $"Ubicación: {user.Street}\n" +
                                $"Tipo de equipo: {asset.Type}\n" +
                                $"Inventario: {asset.Name}\n" +
                                $"Serie del equipo: {asset.SerieNro}\n" +
                                $"Ubicación: {user.Street}\n" +
                                $"Celular: {user.Phone}\n",
                    Asset = asset,
                    Attachments = _mapper.Map<List<TicketAttachments>>(_convertFileExtensions.ListConvertFileToBase64(attachments))
                };
                var result = _ticketRepository.AddTicketNoRenewOtrs(
                        _mapper.Map<TicketCredencials>(_otrsCredencialsService.GetOtrsCredencials()),
                        ticket);

                return result;
            } catch {
                return new TicketCreateResponse();
            }
        }

        [Route("norenew")]
        [HttpPut]
        [ProducesResponseType(typeof(TicketUpdateResponse), (int)HttpStatusCode.OK)]
        public async Task<TicketUpdateResponse> UpdateRequerimentNoRenew([FromForm] string ticketId, [FromForm] string customerId, [FromForm] string assetId, [FromForm] List<IFormFile> attachments) {
            try {
                var user = await _customerUserRepository.GetCustomerUserByCip(customerId);
                var asset = await _assetRepository.GetAssetById(assetId);

                if (ticketId == null || user == null || asset == null) {
                    return new TicketUpdateResponse();
                }

                TicketIncidenceCreate ticket = new TicketIncidenceCreate {
                    TicketId = long.Parse(ticketId),
                    Description = $"Apellidos: {user.LastName}\n" +
                                $"Nombres: {user.FirstName}\n" +
                                $"Ubicación: {user.Street}\n" +
                                $"Tipo de equipo: {asset.Type}\n" +
                                $"Inventario: {asset.Name}\n" +
                                $"Serie del equipo: {asset.SerieNro}\n" +
                                $"Ubicación: {user.Street}\n" +
                                $"Celular: {user.Phone}\n",
                    Attachments = _mapper.Map<List<TicketAttachments>>(_convertFileExtensions.ListConvertFileToBase64(attachments))
                };
                var result = _ticketRepository.UpdateTicketOtrs(
                        _mapper.Map<TicketCredencials>(_otrsCredencialsService.GetOtrsCredencials()),
                        ticket);

                return result;
            } catch {
                return new TicketUpdateResponse();
            }
        }
    }
}