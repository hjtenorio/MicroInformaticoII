using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ArticlePlain
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public byte[] Body { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
