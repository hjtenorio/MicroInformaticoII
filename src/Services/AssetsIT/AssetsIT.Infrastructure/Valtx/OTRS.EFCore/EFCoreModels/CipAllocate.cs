using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CipAllocate
    {
        public long Id { get; set; }
        public string Criticality { get; set; }
        public string Impact { get; set; }
        public short PriorityId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public int? ChangeBy { get; set; }
    }
}
