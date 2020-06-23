using System.Threading.Tasks;

namespace AssetsIT.Domain.AggregatesModel.SenderEmailAggregate
{
    public interface ISenderEmailRepository
    {
        Task<bool> SendEmail(EmailComponents email);
        Task<bool> SendEmailMultipleReceivers(EmailComponetsMultipleReceivers email);
    }
}
