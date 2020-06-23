using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqCategoryGroup
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Changed { get; set; }
        public int? ChangedBy { get; set; }
    }
}
