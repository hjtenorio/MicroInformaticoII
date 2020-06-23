using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using System.Collections.Generic;

namespace AssetsIT.Domain.AggregatesModel.CustomerUserAggregate
{
    public class CustomerAssets
    {
        public CustomerUserData CustomerUserData { get; set; }
        public List<Asset> Asset { get; set; }
    }
}
