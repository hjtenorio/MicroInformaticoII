using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class PostmasterFilter
    {
        public string FName { get; set; }
        public short? FStop { get; set; }
        public string FType { get; set; }
        public string FKey { get; set; }
        public string FValue { get; set; }
        public short? FNot { get; set; }
    }
}
