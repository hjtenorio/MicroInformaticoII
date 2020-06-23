using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Sla
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CalendarName { get; set; }
        public int FirstResponseTime { get; set; }
        public short? FirstResponseNotify { get; set; }
        public int UpdateTime { get; set; }
        public short? UpdateNotify { get; set; }
        public int SolutionTime { get; set; }
        public short? SolutionNotify { get; set; }
        public short ValidId { get; set; }
        public string Comments { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
        public int? TypeId { get; set; }
        public int? MinTimeBetIncidents { get; set; }
    }
}
