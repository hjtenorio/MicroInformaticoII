using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Domain.AggregatesModel.SenderEmailAggregate
{
    public class Server
    {
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
