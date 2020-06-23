using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TicketWatcher
    {
        public long TicketId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
