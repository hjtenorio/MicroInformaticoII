using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TimeAccountingUserPeriod
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int PreferencePeriod { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal? WeeklyHours { get; set; }
        public decimal? LeaveDays { get; set; }
        public decimal? Overtime { get; set; }
        public string Status { get; set; }
    }
}
