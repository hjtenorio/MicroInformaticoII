using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Changed { get; set; }
        public int ChangedBy { get; set; }
    }
}
