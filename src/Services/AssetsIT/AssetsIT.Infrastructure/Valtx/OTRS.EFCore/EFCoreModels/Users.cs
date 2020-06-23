using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pw { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
