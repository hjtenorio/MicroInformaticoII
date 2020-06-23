using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class WebUploadCache
    {
        public string FormId { get; set; }
        public string Filename { get; set; }
        public string ContentId { get; set; }
        public string ContentSize { get; set; }
        public string ContentType { get; set; }
        public string Disposition { get; set; }
        public byte[] Content { get; set; }
        public long CreateTimeUnix { get; set; }
    }
}
