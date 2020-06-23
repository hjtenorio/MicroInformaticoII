using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class QueuePreferences
    {
        public int QueueId { get; set; }
        public string PreferencesKey { get; set; }
        public string PreferencesValue { get; set; }
    }
}
