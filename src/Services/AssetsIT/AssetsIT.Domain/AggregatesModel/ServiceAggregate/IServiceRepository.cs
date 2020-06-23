using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetsIT.Domain.AggregatesModel.ServiceAggregate
{
    public interface IServiceRepository
    {
        Task<IEnumerable<ServiceType>> GetService();
        Task<IEnumerable<ServiceName>> GetServiceByServiceName();
        Task<IEnumerable<Service>> GetServiceByServiceTwo();
        Task<IEnumerable<Service>> GetServiceByServiceThree(string serviceTwo);
    }
}
