using AssetsIT.Domain.AggregatesModel.SenderEmailAggregate;
using AssetsIT.Infrastructure.Valtx.SMTP.Client;
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
            return await _SMTPClient.SendEmail(email);
        }

        public async Task<bool> SendEmailMultipleReceivers(EmailComponetsMultipleReceivers email)
        {
            return await _SMTPClient.SendEmailMultipleReceivers(email);
        }
    }
}
