using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GroupCustomerUser
    {
        public string UserId { get; set; }
        public int GroupId { get; set; }
        public string PermissionKey { get; set; }
        public short PermissionValue { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
