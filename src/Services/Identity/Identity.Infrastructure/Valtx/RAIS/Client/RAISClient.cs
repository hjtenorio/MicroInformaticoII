using System.Threading.Tasks;
using Valtx.RAIS.WebService;

namespace Identity.Infrastructure.Valtx.RAIS.Client
{
    public class RAISClient
    {
        private SeguridadServiceClient _client;

        public RAISClient() {
            _client = new SeguridadServiceClient(); //Falta: inyección de depedencias y control de errores
        }

        public async Task<RespuestaOfLoginResponseXxQyVezQ> Authenticate(string username, string password, int idSistema) {
            var log = new Login() {
                Capcha = string.Empty,
                UsoCapcha = false,
                UserExternal = false,
                Usuario = username,
                Password = password,
                Ip = string.Empty
            };

            var response = await _client.AuthenticateAsync(log, idSistema);

            return response;
        }

        public async Task<TreeViewAndUrls> GetMenuStructure(int userId, int idSistema) {
            var response = await _client.ObteberMenuStructuraAsync(userId, idSistema);

            return response;
        }

        public async Task<Respuesta> ChangePassword(string username, string password) {
            SeguridadServiceClient client = new SeguridadServiceClient();

            var response = await client.CambioPasswordAsync(username, password, 0);

            return response;
        }

        public async Task<Usuario> GetUserAuthenticated(string userName, int idSistema) {
            var response = await _client.GetUserAuthenticatedAsync(userName, idSistema);

            return response;
        }
    }
}