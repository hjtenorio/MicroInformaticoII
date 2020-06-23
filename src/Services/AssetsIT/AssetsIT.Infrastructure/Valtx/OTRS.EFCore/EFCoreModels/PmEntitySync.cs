using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class PmEntitySync
    {
        public string EntityType { get; set; }
        public string EntityId { get; set; }
        public string SyncState { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ChangeTime { get; set; }
    }
}
