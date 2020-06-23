using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ConfigitemHistory
    {
        public long Id { get; set; }
        public long ConfigitemId { get; set; }
        public int TypeId { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
