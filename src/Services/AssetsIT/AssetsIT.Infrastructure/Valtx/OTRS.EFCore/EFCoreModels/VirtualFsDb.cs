using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class VirtualFsDb
    {
        public long Id { get; set; }
        public string Filename { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
