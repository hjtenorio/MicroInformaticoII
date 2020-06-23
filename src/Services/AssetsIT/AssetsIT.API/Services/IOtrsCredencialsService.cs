using AssetsIT.API.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.API.Services
{
    public interface IOtrsCredencialsService
    {
        OtrsCredencialsDTOResponse GetOtrsCredencials();
    }
}
