using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GiDebuggerEntry
    {
        public long Id { get; set; }
        public string CommunicationId { get; set; }
        public string CommunicationType { get; set; }
        public string RemoteIp { get; set; }
        public int WebserviceId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
