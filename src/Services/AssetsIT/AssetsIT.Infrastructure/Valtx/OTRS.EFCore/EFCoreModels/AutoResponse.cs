using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class AutoResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text0 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public short TypeId { get; set; }
        public short SystemAddressId { get; set; }
        public string Charset { get; set; }
        public string ContentType { get; set; }
        public string Comments { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
