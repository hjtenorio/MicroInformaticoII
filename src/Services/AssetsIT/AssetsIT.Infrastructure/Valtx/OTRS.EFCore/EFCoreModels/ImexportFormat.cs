using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ImexportFormat
    {
        public long Id { get; set; }
        public long TemplateId { get; set; }
        public string DataKey { get; set; }
        public string DataValue { get; set; }
    }
}
