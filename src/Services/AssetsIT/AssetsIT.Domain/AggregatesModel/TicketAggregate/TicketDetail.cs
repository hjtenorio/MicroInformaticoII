using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Domain.AggregatesModel.TicketAggregate
{
    public class TicketDetail
    {
        public long Id { get; set; }
        public string Tn { get; set; }
        public string Title { get; set; }        
        public short TicketPriorityId { get; set; }
        public string TicketPriority { get; set; }
        public string CustomerId { get; set; }        
        public DateTime CreateTime { get; set; }
        public TicketArticle TicketArticle { get; set; }
    }
}
