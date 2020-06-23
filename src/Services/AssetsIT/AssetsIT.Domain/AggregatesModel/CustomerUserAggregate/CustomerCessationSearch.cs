using System;

namespace AssetsIT.Domain.AggregatesModel.CustomerUserAggregate
{
    public class CustomerCessationSearch
    {
        public string ChiefCustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndtDate { get; set; }
    }
}
