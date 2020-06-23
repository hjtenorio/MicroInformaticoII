using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ConditionExpression
    {
        public long Id { get; set; }
        public long ConditionId { get; set; }
        public short ObjectId { get; set; }
        public short AttributeId { get; set; }
        public short OperatorId { get; set; }
        public string Selector { get; set; }
        public string CompareValue { get; set; }
    }
}
