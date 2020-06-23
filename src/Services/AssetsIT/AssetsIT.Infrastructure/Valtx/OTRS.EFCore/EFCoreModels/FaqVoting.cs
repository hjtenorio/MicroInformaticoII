using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqVoting
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public int ItemId { get; set; }
        public string Interface { get; set; }
        public string Ip { get; set; }
        public int Rate { get; set; }
        public DateTime? Created { get; set; }
    }
}
