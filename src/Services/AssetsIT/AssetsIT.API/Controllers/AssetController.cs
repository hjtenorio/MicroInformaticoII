using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AssetsIT.Domain.AggregatesModel.AssetsAggregate;

namespace AssetsIT.API.Controllers
{
    [Route("api/v1/[controller]")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class AssetController : Controller
    {
        private readonly IAssetRepository _assetRepository;

        public AssetController(IAssetRepository assetRepository) {
            _assetRepository = assetRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Asset), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<Asset>> GetAssetsByOwner(string ownerId) {
            return await _assetRepository.GetAssetsByOwner(ownerId);
        }
    }
}