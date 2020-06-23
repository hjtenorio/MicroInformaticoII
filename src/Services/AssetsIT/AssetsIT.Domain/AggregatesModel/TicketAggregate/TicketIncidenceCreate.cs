using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using System.Collections.Generic;

namespace AssetsIT.Domain.AggregatesModel.TicketAggregate
{
    public class TicketIncidenceCreate
    {
        public string UserCip { get; set; }
        public long TicketId { get; set; }
        public int OtrsServiceId { get; set; }
        public string Description { get; set; }
        public Asset Asset { get; set; }
        public List<TicketAttachments> Attachments { get; set; }
    }
}
