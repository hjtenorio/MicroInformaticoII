using System;
using System.Collections.Generic;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public partial class Ticket
    {
        public long Id { get; set; }
        public string Tn { get; set; }
        public string Title { get; set; }
        public int QueueId { get; set; }
        public short TicketLockId { get; set; }
        public short? TypeId { get; set; }
        public int? ServiceId { get; set; }
        public int? SlaId { get; set; }
        public int UserId { get; set; }
        public int ResponsibleUserId { get; set; }
        public short TicketPriorityId { get; set; }
        public short TicketStateId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerUserId { get; set; }
        public int Timeout { get; set; }
        public int UntilTime { get; set; }
        public int EscalationTime { get; set; }
        public int EscalationUpdateTime { get; set; }
        public int EscalationResponseTime { get; set; }
        public int EscalationSolutionTime { get; set; }
        public short ArchiveFlag { get; set; }
        public long CreateTimeUnix { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
