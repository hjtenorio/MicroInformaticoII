using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SystemData
    {
        public string DataKey { get; set; }
        public byte[] DataValue { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
