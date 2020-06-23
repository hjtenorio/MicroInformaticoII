using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeCipAllocate
    {
        public long Id { get; set; }
        public int CategoryId { get; set; }
        public int ImpactId { get; set; }
        public int PriorityId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public int? ChangeBy { get; set; }
    }
}
