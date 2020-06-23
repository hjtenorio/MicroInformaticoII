using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ConfigitemVersion
    {
        public long Id { get; set; }
        public long ConfigitemId { get; set; }
        public string Name { get; set; }
        public int DefinitionId { get; set; }
        public int DeplStateId { get; set; }
        public int? InciStateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
