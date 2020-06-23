using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request
{
    public class AttachmentRequest
    {
        public string Content { get; set; }
        public string ContentType { get; set; }
        public string Filename { get; set; }

        //public AttachmentRequest(string content, string contentType, string filename)
        //{
        //    this.Content = content;
        //    this.ContentType = contentType;
        //    this.Filename = filename;
        //}
    }
}
