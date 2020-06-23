using System.Threading.Tasks;

namespace Identity.Domain.AggregatesModel.SenderEmailAggregate
{
    public interface ISenderEmailRepository
    {
        Task<bool> SendEmail(EmailComponents email);
    }
}
