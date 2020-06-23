using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeCab
    {
        public long Id { get; set; }
        public long ChangeId { get; set; }
        public int? UserId { get; set; }
        public string CustomerUserId { get; set; }
    }
}
