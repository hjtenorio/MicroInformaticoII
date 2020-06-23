using System;

namespace AssetsIT.Domain.AggregatesModel.TrackingAggregate
{
    public class QueueTicket
    {
        public string TicketNumber { get; set; }
        public string TypeID { get; set; }
        public string Type { get; set; }
        public string Work { get; set; }
        public string Queue { get; set; }
        public string ProcessQueue { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string DiferenceTime { get; set; }
        public string Status { get; set; }
    }
}
