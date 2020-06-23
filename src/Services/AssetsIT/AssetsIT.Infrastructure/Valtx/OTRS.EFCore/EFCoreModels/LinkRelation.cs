using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class LinkRelation
    {
        public short SourceObjectId { get; set; }
        public string SourceKey { get; set; }
        public short TargetObjectId { get; set; }
        public string TargetKey { get; set; }
        public short TypeId { get; set; }
        public short StateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
