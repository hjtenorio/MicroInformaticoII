using System;

namespace AssetsIT.Domain.AggregatesModel.CustomerUserAggregate
{
    public class CustomerCessationUpdate
    {
        public int IdUser { get; set; }

        public DateTime? DateEndcontrat { get; set; }
    }
}