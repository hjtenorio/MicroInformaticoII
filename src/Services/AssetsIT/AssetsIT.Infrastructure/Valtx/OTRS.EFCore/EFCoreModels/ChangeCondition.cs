using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeCondition
    {
        public long Id { get; set; }
        public long ChangeId { get; set; }
        public string Name { get; set; }
        public string ExpressionConjunction { get; set; }
        public string Comments { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
