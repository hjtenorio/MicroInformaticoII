using AssetsIT.API.Configuration;
using AssetsIT.API.Models.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace AssetsIT.API.Services
{
    public class OtrsCredencialsService : IOtrsCredencialsService
    {
        private readonly OtrsConnectionStrings _otrsConnectionStrings;
        public OtrsCredencialsService(IOptions<OtrsConnectionStrings> otrsConnectionStrings)
        {
            _otrsConnectionStrings = otrsConnectionStrings.Value;
        }

        public OtrsCredencialsDTOResponse GetOtrsCredencials()
        {
            OtrsCredencialsDTOResponse request = new OtrsCredencialsDTOResponse
            {
                WebBaseUrl = _otrsConnectionStrings.WebBaseUrl,
                UserLogin = _otrsConnectionStrings.UserLogin,
                CustomerUserLogin = _otrsConnectionStrings.CustomerUserLogin,
                Password = _otrsConnectionStrings.Password
            };

            return request;
        }
    }
}
