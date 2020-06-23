using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GiObjectLockState
    {
        public int WebserviceId { get; set; }
        public string ObjectType { get; set; }
        public long ObjectId { get; set; }
        public string LockState { get; set; }
        public int LockStateCounter { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ChangeTime { get; set; }
    }
}
