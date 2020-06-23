using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request
{
    public class TicketBodyUpdateRequest
    {
        public string UserLogin { get; set; }
        public string CustomerUserLogin { get; set; }
        public string Password { get; set; }        
        public ArticleRequest Article { get; set; }
        public List<AttachmentRequest> Attachment { get; set; }
    }
}
