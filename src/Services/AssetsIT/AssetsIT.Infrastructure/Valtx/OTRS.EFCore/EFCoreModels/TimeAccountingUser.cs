using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TimeAccountingUser
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public int? ShowOvertime { get; set; }
        public int? CreateProject { get; set; }
        public int? Calendar { get; set; }
    }
}
