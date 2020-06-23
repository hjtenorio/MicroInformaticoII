using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TimeAccounting
    {
        public long Id { get; set; }
        public long TicketId { get; set; }
        public long? ArticleId { get; set; }
        public decimal TimeUnit { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
