using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.API.Models.Request
{
    public class CustomerAssetsRequest
    {
        public CustomerUserData CustomerUserData { get; set; }
        public Asset Asset { get; set; }
    }
}
