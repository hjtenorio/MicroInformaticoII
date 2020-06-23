using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqLog
    {
        public long Id { get; set; }
        public int ItemId { get; set; }
        public string Interface { get; set; }
        public string Ip { get; set; }
        public string UserAgent { get; set; }
        public DateTime Created { get; set; }
    }
}
