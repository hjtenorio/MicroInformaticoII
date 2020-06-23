using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Domain.AggregatesModel.TicketAggregate
{
    public class TicketsEmployeeSearch
    {
        public string CustomerId { get; set; }
        public string SearchContent { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndtDate { get; set; }
        public int? ServiceTypeId { get; set; }
        public int? TicketStatusId { get; set; }
    }
}
