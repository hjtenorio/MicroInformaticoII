using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class PackageRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Vendor { get; set; }
        public string InstallStatus { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
