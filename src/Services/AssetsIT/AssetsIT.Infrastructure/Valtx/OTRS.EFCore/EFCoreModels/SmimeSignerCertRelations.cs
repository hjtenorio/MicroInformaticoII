using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SmimeSignerCertRelations
    {
        public int Id { get; set; }
        public string CertHash { get; set; }
        public string CertFingerprint { get; set; }
        public string CaHash { get; set; }
        public string CaFingerprint { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
