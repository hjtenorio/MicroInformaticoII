using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetsIT.Domain.AggregatesModel.AssetsAggregate
{
    public interface IAssetRepository
    {
        Task<IEnumerable<Asset>> GetAssetsByOwner(string ownerId);
        Task<Asset> GetAssetById(string assetId);
        Task<bool> UpdateAssetByStolen(string assetId);
    }
}
