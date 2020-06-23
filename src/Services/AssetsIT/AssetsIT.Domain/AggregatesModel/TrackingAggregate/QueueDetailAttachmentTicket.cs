using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Domain.AggregatesModel.TrackingAggregate
{
    public class QueueDetailAttachmentTicket
    {
        public int ArticuleId { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
    }
}
