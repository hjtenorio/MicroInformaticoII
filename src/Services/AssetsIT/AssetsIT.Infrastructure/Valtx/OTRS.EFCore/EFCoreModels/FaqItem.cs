using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class FaqItem
    {
        public int Id { get; set; }
        public string FNumber { get; set; }
        public string FSubject { get; set; }
        public string FName { get; set; }
        public short FLanguageId { get; set; }
        public short StateId { get; set; }
        public short CategoryId { get; set; }
        public short Approved { get; set; }
        public short ValidId { get; set; }
        public string FKeywords { get; set; }
        public string FField1 { get; set; }
        public string FField2 { get; set; }
        public string FField3 { get; set; }
        public string FField4 { get; set; }
        public string FField5 { get; set; }
        public string FField6 { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Changed { get; set; }
        public int ChangedBy { get; set; }
    }
}
