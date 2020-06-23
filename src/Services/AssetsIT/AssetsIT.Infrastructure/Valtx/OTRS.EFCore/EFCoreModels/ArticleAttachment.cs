using System;
using System.Collections.Generic;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public partial class ArticleAttachment
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public string Filename { get; set; }
        public string ContentSize { get; set; }
        public string ContentType { get; set; }
        public string ContentId { get; set; }
        public string ContentAlternative { get; set; }
        public string Disposition { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
