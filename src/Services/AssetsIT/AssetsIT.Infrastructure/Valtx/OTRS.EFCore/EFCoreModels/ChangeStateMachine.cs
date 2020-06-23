using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeStateMachine
    {
        public long Id { get; set; }
        public int? StateId { get; set; }
        public int? NextStateId { get; set; }
    }
}
