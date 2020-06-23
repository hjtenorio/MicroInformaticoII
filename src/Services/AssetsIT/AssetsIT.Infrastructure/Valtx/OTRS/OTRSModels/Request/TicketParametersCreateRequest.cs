using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request
{
    public class TicketParametersCreateRequest
    {
        public string Title { get; set; }
        public string CustomerUser { get; set; }
        public string Queue { get; set; }
        public string Priority { get; set; }
        public string State { get; set; }
        public int? TypeID { get; set; }
        public int? ServiceID { get; set; }
    }
}
