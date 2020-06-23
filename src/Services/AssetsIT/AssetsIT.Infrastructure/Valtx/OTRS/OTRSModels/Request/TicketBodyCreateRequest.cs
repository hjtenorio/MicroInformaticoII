using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request
{
    public class TicketBodyCreateRequest
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string UserLogin { get; set; }
        public string CustomerUserLogin { get; set; }
        public string Password { get; set; }
        public TicketParametersCreateRequest Ticket { get; set; }
        public ArticleRequest Article { get; set; }
        public List<AttachmentRequest> Attachment { get; set; }
    }
}
