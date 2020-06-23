using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class PmProcess
    {
        public int Id { get; set; }
        public string EntityId { get; set; }
        public string Name { get; set; }
        public string StateEntityId { get; set; }
        public byte[] Layout { get; set; }
        public byte[] Config { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
