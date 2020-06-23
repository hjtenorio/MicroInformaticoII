using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Domain.AggregatesModel.TicketAggregate
{
    public class TicketArticle
    {
        public long Id { get; set; }
        public long TicketId { get; set; }
        public string ABody { get; set; }
    }
}
