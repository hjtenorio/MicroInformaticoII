using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.API.Models.Request
{
    public class IncidenceCreateRequest
    {
        public string UserDni { get; set; }
        public int OtrsServiceID { get; set; }
        public string Description { get; set; }
        public string AssetId { get; set; }
    }
}
