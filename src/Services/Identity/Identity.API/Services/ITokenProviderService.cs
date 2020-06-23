using Identity.API.Models.Request;
using Identity.API.Models.Response;
using System.Threading.Tasks;

namespace Identity.API.Services
{
    public interface ITokenProviderService
    {
        Task<IdentityTokenResponse> GetToken(IdentityTokenRequest request);
    }
}
