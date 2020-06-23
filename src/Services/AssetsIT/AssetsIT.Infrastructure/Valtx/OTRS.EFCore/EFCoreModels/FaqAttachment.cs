using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqAttachment
    {
        public long Id { get; set; }
        public long FaqId { get; set; }
        public string Filename { get; set; }
        public string ContentSize { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public short Inlineattachment { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Changed { get; set; }
        public int ChangedBy { get; set; }
    }
}
