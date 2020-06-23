using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeItem
    {
        public long Id { get; set; }
        public string ChangeNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionPlain { get; set; }
        public string Justification { get; set; }
        public string JustificationPlain { get; set; }
        public int ChangeStateId { get; set; }
        public int? ChangeManagerId { get; set; }
        public int ChangeBuilderId { get; set; }
        public int CategoryId { get; set; }
        public int ImpactId { get; set; }
        public int PriorityId { get; set; }
        public DateTime? RequestedTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
