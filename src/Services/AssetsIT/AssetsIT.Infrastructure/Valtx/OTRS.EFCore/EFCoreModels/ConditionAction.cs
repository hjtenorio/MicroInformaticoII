using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ConditionAction
    {
        public long Id { get; set; }
        public long ConditionId { get; set; }
        public int ActionNumber { get; set; }
        public short ObjectId { get; set; }
        public short AttributeId { get; set; }
        public short OperatorId { get; set; }
        public string Selector { get; set; }
        public string ActionValue { get; set; }
    }
}
