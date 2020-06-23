using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SystemMaintenance
    {
        public int Id { get; set; }
        public int StartDate { get; set; }
        public int StopDate { get; set; }
        public string Comments { get; set; }
        public string LoginMessage { get; set; }
        public short? ShowLoginMessage { get; set; }
        public string NotifyMessage { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
