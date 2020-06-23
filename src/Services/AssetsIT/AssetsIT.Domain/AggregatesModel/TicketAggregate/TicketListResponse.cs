using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Domain.AggregatesModel.TicketAggregate
{
    public class TicketListResponse
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceType { get; set; }
        public string Title { get; set; }
        public DateTime? CreateTime { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
    }
}
