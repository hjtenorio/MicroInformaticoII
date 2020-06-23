using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GiWebserviceConfigHistory
    {
        public long Id { get; set; }
        public int ConfigId { get; set; }
        public byte[] Config { get; set; }
        public string ConfigMd5 { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
