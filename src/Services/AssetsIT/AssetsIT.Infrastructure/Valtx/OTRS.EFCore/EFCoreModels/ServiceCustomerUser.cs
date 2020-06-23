using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ServiceCustomerUser
    {
        public string CustomerUserLogin { get; set; }
        public int ServiceId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
    }
}
