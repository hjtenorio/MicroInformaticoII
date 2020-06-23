using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqCategory
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public short ValidId { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Changed { get; set; }
        public int ChangedBy { get; set; }
    }
}
