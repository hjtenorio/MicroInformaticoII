using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class AclSync
    {
        public string AclId { get; set; }
        public string SyncState { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ChangeTime { get; set; }
    }
}
