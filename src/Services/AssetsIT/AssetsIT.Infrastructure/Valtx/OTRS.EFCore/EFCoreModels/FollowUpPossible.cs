using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FollowUpPossible
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
