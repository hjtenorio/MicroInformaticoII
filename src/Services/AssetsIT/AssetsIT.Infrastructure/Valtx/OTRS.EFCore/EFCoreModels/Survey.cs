using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Survey
    {
        public long Id { get; set; }
        public string Surveynumber { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Description { get; set; }
        public string NotificationSender { get; set; }
        public string NotificationSubject { get; set; }
        public string NotificationBody { get; set; }
        public string Status { get; set; }
        public string SendConditions { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public int? ChangeBy { get; set; }
    }
}
