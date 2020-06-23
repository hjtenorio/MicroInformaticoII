using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ConfigitemDefinition
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public byte[] ConfigitemDefinition1 { get; set; }
        public int Version { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
