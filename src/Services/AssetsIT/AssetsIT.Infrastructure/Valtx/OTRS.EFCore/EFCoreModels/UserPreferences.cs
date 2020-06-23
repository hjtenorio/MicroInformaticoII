using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class UserPreferences
    {
        public int UserId { get; set; }
        public string PreferencesKey { get; set; }
        public byte[] PreferencesValue { get; set; }
    }
}
