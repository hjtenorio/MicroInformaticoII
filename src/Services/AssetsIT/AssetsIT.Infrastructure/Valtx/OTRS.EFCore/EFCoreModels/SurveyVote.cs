using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SurveyVote
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long QuestionId { get; set; }
        public string VoteValue { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
