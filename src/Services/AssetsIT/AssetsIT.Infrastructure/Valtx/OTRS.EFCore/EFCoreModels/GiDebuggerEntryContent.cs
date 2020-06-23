using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GiDebuggerEntryContent
    {
        public long Id { get; set; }
        public long GiDebuggerEntryId { get; set; }
        public string DebugLevel { get; set; }
        public string Subject { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
