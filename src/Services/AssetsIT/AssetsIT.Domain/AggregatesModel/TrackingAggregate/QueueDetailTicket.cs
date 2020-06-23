using System;
using System.Collections.Generic;

namespace AssetsIT.Domain.AggregatesModel.TrackingAggregate
{
    public class QueueDetailTicket
    {
        public int QueueId { get; set; }
        public int ArticuleId { get; set; }
        public string ABody { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string Especialist { get; set; }
        public int HistoryType { get; set; }
        public List<QueueDetailAttachmentTicket> QueueDetailAttachments { get; set; }
        //public List<IFormFile> QueueDetailAttachmentsFiles { get; set; }
    }
}