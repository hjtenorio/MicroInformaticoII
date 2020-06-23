using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GiWebserviceConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Config { get; set; }
        public string ConfigMd5 { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
