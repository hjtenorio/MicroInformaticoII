using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ArticleSearch
    {
        public long Id { get; set; }
        public long TicketId { get; set; }
        public short ArticleTypeId { get; set; }
        public short ArticleSenderTypeId { get; set; }
        public string AFrom { get; set; }
        public string ATo { get; set; }
        public string ACc { get; set; }
        public string ASubject { get; set; }
        public string ABody { get; set; }
        public int IncomingTime { get; set; }
    }
}
