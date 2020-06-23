using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetsIT.Domain.AggregatesModel.TrackingAggregate
{
    public interface ITrackingRepository
    {
        Task<IEnumerable<QueueTicket>> GetListQueueTicket(string nroTicket);
        Task<IEnumerable<QueueDetailTicket>> GetListQueueDetailTicket(string nroTicket, string nameQueue);
    }
}
