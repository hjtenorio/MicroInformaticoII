using AssetsIT.Domain.AggregatesModel.ServiceAggregate;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFRepositories
{
    public class ServiceEFRepository : IServiceRepository
    {
        private OTRSContext _OTRSContext;
        public ServiceEFRepository(OTRSContext OTRSContext)
        {
            _OTRSContext = OTRSContext;
        }

        public async Task<IEnumerable<ServiceType>> GetService()
        {
            var service = (from tt in _OTRSContext.TicketType
                           where tt.Id == 2 || tt.Id == 7
                           select new ServiceType
                           {
                               Id = tt.Id,
                               Name = tt.Name
                           });

            return await service.ToListAsync();
        }

        public async Task<ServiceType> GetServiceById(int id)
        {
            var service = (from tt in _OTRSContext.TicketType
                           where tt.Id == id
                           select new ServiceType
                           {
                               Id = tt.Id,
                               Name = tt.Name
                           });

            return await service.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ServiceName>> GetServiceByServiceName()
        {
            var service = (from cc in _OTRSContext.VwService
                           select new ServiceName
                           {
                               Id = cc.Id,
                               Name = cc.ServiceFullName,
                               TypeService = cc.TypeService,
                               TypeServiceName = cc.TypeServiceName
                           }).Distinct();

            return await service.ToListAsync();
        }

        public async Task<IEnumerable<Service>> GetServiceByServiceTwo()
        {
            var service = (from cc in _OTRSContext.VwService
                          select new Service
                          {
                                Service2 = cc.Service2
                          }).Distinct();

            return await service.ToListAsync();
        }

        public async Task<IEnumerable<Service>> GetServiceByServiceThree(string serviceTwo)
        {
            var service = (from cc in _OTRSContext.VwService
                           where cc.Service2 == serviceTwo
                           select new Service
                           {
                               Id = cc.Id,
                               Service1 = cc.Service1,
                               Service2 = cc.Service2,
                               Service3 = cc.Service3,
                               TypeService = cc.TypeService,
                               TypeServiceName = cc.TypeServiceName
                           }).Distinct();

            return await service.ToListAsync();
        }
    }
}
