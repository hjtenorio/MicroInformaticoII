using AssetsIT.API.Models;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AssetsIT.Domain.AggregatesModel.TrackingAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AssetsIT.API.Controllers
{
    [Route("api/v1/[controller]")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class TrackingController : Controller
    {
        public readonly ITrackingRepository _trackingRepository;
        private readonly ICustomerUserRepository _customerUserRepository;
        private readonly ITicketRepository _ticketRepository;

        public TrackingController(ITrackingRepository trackingRepository,
            ICustomerUserRepository customerUserRepository,
            ITicketRepository ticketRepository) {
            _trackingRepository = trackingRepository;
            _customerUserRepository = customerUserRepository;
            _ticketRepository = ticketRepository;
        }

        [Route("tickets-list-employee")]
        [HttpGet]
        [ProducesResponseType(typeof(TicketListResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<PaginatedItems<TicketListResponse>>> GetListTicketByCustomerId(string nroDni, string nroTicketTitle, int? serviceTypeId, int? ticketStatusId, DateTime? startDate, DateTime? endDate, [FromQuery]int pageSize = 10, [FromQuery]int pageIndex = 0) {
            var user = await _customerUserRepository.GetCustomerUserByDni(nroDni);
            if (user == null) {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            TicketsEmployeeSearch search = new TicketsEmployeeSearch {
                CustomerId = user?.CustomerId,
                SearchContent = nroTicketTitle ?? string.Empty,
                StartDate = startDate ?? null,
                EndtDate = endDate ?? null,
                ServiceTypeId = serviceTypeId ?? -1,
                TicketStatusId = ticketStatusId ?? -1
            };
            var response = await _ticketRepository.GetListTicketByCustomerId(search);

            var totalItems = response.Count();

            var itemsOnPage = response
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();

            return new PaginatedItems<TicketListResponse>(pageIndex, pageSize, totalItems, itemsOnPage);
        }

        [Route("ticket-detail")]
        [HttpGet]
        [ProducesResponseType(typeof(TicketListResponse), (int)HttpStatusCode.OK)]
        public async Task<TicketDetail> GetTicketDetailByNroTicket(string nroTicket) {
            return await _ticketRepository.GetTicketDetailByNroTicket(nroTicket);
        }

        [Route("ticket-states")]
        [HttpGet]
        [ProducesResponseType(typeof(TicketState), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<TicketState>> GetTicketState() {
            return await _ticketRepository.GetTicketState();
        }

        [Route("ticket-queue")]
        [HttpGet]
        [ProducesResponseType(typeof(QueueTicket), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<QueueTicket>> GetListQueueTicket(string nroTicket) {
            return await _trackingRepository.GetListQueueTicket(nroTicket);
        }

        [Route("ticket-queue-detail")]
        [HttpGet]
        [ProducesResponseType(typeof(QueueDetailTicket), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<QueueDetailTicket>> GetListQueueDetailTicket(string nroTicket, string nameQueue) {
            var result = await _trackingRepository.GetListQueueDetailTicket(nroTicket, nameQueue);

            return result;
        }
    }
}