using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class TimeAccountingTable
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public long ProjectId { get; set; }
        public long ActionId { get; set; }
        public string Remark { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public decimal? Period { get; set; }
        public DateTime Created { get; set; }
    }
}
