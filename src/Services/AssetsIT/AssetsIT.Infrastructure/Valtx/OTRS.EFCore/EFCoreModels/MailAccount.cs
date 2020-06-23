using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class MailAccount
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pw { get; set; }
        public string Host { get; set; }
        public string AccountType { get; set; }
        public int QueueId { get; set; }
        public short Trusted { get; set; }
        public string ImapFolder { get; set; }
        public string Comments { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
