using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request
{
    public class ArticleRequest
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ContentType { get; set; }
        public string SenderType { get; set; }
        public string TimeUnit { get; set; }
    }
}
