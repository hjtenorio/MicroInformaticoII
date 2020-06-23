using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SurveyRequest
    {
        public long Id { get; set; }
        public long TicketId { get; set; }
        public long SurveyId { get; set; }
        public short ValidId { get; set; }
        public string PublicSurveyKey { get; set; }
        public string SendTo { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? VoteTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
