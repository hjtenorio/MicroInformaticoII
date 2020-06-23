using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ImexportTemplate
    {
        public long Id { get; set; }
        public string ImexportObject { get; set; }
        public string ImexportFormat { get; set; }
        public string Name { get; set; }
        public short ValidId { get; set; }
        public string Comments { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public int? ChangeBy { get; set; }
    }
}
