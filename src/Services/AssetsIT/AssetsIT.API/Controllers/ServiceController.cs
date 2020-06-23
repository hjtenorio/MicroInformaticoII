using AssetsIT.Domain.AggregatesModel.ServiceAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AssetsIT.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository) {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ServiceName), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<ServiceName>> GetService()
        {
            return await _serviceRepository.GetServiceByServiceName();
        }
    }
}