using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TicketIndex
    {
        public long TicketId { get; set; }
        public int QueueId { get; set; }
        public string Queue { get; set; }
        public int GroupId { get; set; }
        public string SLock { get; set; }
        public string SState { get; set; }
        public long CreateTimeUnix { get; set; }
    }
}
