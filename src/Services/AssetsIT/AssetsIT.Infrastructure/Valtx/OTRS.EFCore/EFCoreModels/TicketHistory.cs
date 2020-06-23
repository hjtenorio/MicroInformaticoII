using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TicketHistory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public short HistoryTypeId { get; set; }
        public long TicketId { get; set; }
        public long? ArticleId { get; set; }
        public short TypeId { get; set; }
        public int QueueId { get; set; }
        public int OwnerId { get; set; }
        public short PriorityId { get; set; }
        public short StateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
