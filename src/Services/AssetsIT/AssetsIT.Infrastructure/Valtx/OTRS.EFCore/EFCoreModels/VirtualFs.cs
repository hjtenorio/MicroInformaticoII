using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class VirtualFs
    {
        public long Id { get; set; }
        public string Filename { get; set; }
        public string Backend { get; set; }
        public string BackendKey { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
