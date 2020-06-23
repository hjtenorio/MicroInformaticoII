using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SchedulerTaskList
    {
        public long Id { get; set; }
        public string TaskData { get; set; }
        public string TaskDataMd5 { get; set; }
        public string TaskType { get; set; }
        public DateTime DueTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
