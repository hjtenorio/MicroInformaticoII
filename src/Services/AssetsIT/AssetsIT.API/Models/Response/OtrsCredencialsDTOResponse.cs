using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.API.Models.Response
{
    public class OtrsCredencialsDTOResponse
    {
        public string WebBaseUrl { get; set; }
        public string UserLogin { get; set; }
        public string CustomerUserLogin { get; set; }
        public string Password { get; set; }
    }
}
