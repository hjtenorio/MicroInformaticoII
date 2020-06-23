using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeNotification
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ItemAttribute { get; set; }
        public int EventId { get; set; }
        public short ValidId { get; set; }
        public string Comments { get; set; }
        public string NotificationRule { get; set; }
    }
}
