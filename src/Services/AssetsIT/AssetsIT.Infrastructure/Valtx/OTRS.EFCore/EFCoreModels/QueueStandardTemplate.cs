using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class QueueStandardTemplate
    {
        public int QueueId { get; set; }
        public int StandardTemplateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
