using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetsIT.Domain.AggregatesModel.TicketAggregate
{
    public interface ITicketRepository
    {
        Task<IEnumerable<TicketListResponse>> GetListTicketByCustomerId(TicketsEmployeeSearch search);
        Task<TicketDetail> GetTicketDetailByNroTicket(string nroTicket);
        Task<IEnumerable<TicketState>> GetTicketState();
        TicketCreateResponse AddTicketIncidenceOtrs(TicketCredencials ticketCredencials, TicketIncidenceCreate ticket);
        TicketCreateResponse AddTicketNoRenewOtrs(TicketCredencials ticketCredencials, TicketIncidenceCreate ticket);
        TicketUpdateResponse UpdateTicketOtrs(TicketCredencials ticketCredencials, TicketIncidenceCreate ticket);
    }
}