using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Acl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public short ValidId { get; set; }
        public short? StopAfterMatch { get; set; }
        public byte[] ConfigMatch { get; set; }
        public byte[] ConfigChange { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
