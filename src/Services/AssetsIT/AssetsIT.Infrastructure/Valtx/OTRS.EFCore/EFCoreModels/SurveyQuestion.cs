using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SurveyQuestion
    {
        public long Id { get; set; }
        public long SurveyId { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; }
        public short Position { get; set; }
        public short? AnswerRequired { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public int? ChangeBy { get; set; }
    }
}
