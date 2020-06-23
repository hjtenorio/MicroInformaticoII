using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public string NotificationType { get; set; }
        public string NotificationCharset { get; set; }
        public string NotificationLanguage { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string ContentType { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
