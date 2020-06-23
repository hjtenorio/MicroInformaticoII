using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Configitem
    {
        public long Id { get; set; }
        public string ConfigitemNumber { get; set; }
        public int ClassId { get; set; }
        public long? LastVersionId { get; set; }
        public int? CurDeplStateId { get; set; }
        public int? CurInciStateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
