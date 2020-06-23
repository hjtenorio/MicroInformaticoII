using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Sessions
    {
        public long Id { get; set; }
        public string SessionId { get; set; }
        public string DataKey { get; set; }
        public string DataValue { get; set; }
        public short Serialized { get; set; }
    }
}
