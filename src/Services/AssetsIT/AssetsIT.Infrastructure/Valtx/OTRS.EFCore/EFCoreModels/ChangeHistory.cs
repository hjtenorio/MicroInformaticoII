using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeHistory
    {
        public long Id { get; set; }
        public long ChangeId { get; set; }
        public long? WorkorderId { get; set; }
        public int TypeId { get; set; }
        public string ContentNew { get; set; }
        public string ContentOld { get; set; }
        public string Fieldname { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
