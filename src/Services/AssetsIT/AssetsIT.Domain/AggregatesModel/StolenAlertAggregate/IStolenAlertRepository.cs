using AssetsIT.Domain.AggregatesModel.TicketAggregate;

namespace AssetsIT.Domain.AggregatesModel.StolenAlertAggregate
{
    public interface IStolenAlertRepository
    {
        TicketCreateResponse AddStolenAlert(TicketCredencials ticketCredencials, StolenAlert stolenAlert);
    }
}