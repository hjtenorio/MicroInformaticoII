using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ImexportMappingFormat
    {
        public long Id { get; set; }
        public long MappingId { get; set; }
        public string DataKey { get; set; }
        public string DataValue { get; set; }
    }
}
