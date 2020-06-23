using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ArticleFlag
    {
        public long ArticleId { get; set; }
        public string ArticleKey { get; set; }
        public string ArticleValue { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
