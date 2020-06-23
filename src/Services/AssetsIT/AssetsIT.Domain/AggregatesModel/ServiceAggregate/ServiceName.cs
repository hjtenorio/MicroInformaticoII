using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Domain.AggregatesModel.ServiceAggregate
{
    public class ServiceName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeService { get; set; }
        public string TypeServiceName { get; set; }
    }
}
