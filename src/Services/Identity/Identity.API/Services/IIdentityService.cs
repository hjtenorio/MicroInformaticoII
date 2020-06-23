using System.Threading.Tasks;
using Valtx.RAIS.WebService;

namespace Identity.API.Services
{
    public interface IIdentityService
    {
        Task<bool> SendEmailForgotPassword(Usuario user, string name, string login);
    }
}
