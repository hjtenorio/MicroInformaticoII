using Identity.Domain.AggregatesModel.SenderEmailAggregate;
using Identity.Infrastructure.Valtx.SMTP.Client;
using System.Threading.Tasks;

namespace Identity.Infrastructure.Valtx.SMTP.Repositories
{
    public class SenderEmailRepository : ISenderEmailRepository
    {
        private SMTPClient _SMTPClient;
        public SenderEmailRepository(SMTPClient SMTPClient)
        {
            _SMTPClient = SMTPClient;
        }

        public async Task<bool> SendEmail(EmailComponents email)
        {
            return await _SMTPClient.SendEmail(email); ;
        }
    }
}
