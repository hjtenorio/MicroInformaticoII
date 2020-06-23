using System;
using System.Collections.Generic;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public partial class TicketState
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public short TypeId { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
        public string NameSpn { get; set; }
    }
}
