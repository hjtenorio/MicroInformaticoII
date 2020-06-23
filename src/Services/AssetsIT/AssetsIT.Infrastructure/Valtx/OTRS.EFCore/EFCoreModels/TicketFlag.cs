using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TicketFlag
    {
        public long TicketId { get; set; }
        public string TicketKey { get; set; }
        public string TicketValue { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
