using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SurveyAnswer
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string Answer { get; set; }
        public int Position { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public int? ChangeBy { get; set; }
    }
}
