using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFRepositories
{
    public class AssetEFRepository : IAssetRepository
    {
        private OTRSContext _OTRSContext;
        private OTRSOptions _OTRSOpions;

        public AssetEFRepository(OTRSContext OTRSContext, IOptionsMonitor<OTRSOptions> OTRSOpions) {
            _OTRSContext = OTRSContext;
            _OTRSOpions = OTRSOpions.CurrentValue;
        }

        public async Task<IEnumerable<Asset>> GetAssetsByOwner(string ownerId) {
            var result = (from cc in _OTRSContext.CmdbCpu
                          join cu in _OTRSContext.CustomerUser on cc.Owner equals cu.CustomerId
                          where cu.Dni == ownerId &&
                                (cc.Type == "Laptop" ||
                                cc.Type == "Desktop") &&
                                cc.DeploymentState == "Production" &&
                                cc.OrdenCompra != "CONTRATA"
                          orderby cc.Id ascending
                          select new Asset {
                              Id = cc.Id,
                              Name = cc.Name,
                              Model = cc.Modelo,
                              SerieNro = cc.Serie,
                              BuyOrder = cc.OrdenCompra,
                              Type = cc.Type
                          });

            return await result.ToListAsync();
        }

        public async Task<Asset> GetAssetById(string assetId) {
            var result = (from cc in _OTRSContext.CmdbCpu
                          where cc.Id == assetId
                          orderby cc.Id ascending
                          select new Asset {
                              Id = cc.Id,
                              Name = cc.Name,
                              Model = cc.Modelo,
                              SerieNro = cc.Serie,
                              BuyOrder = cc.OrdenCompra,
                              Type = cc.Type
                          });

            return await result.FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAssetByStolen(string assetId) {
            bool result;
            var obj = await _OTRSContext.CmdbCpu.FindAsync(assetId);

            obj.DeploymentState = _OTRSOpions.AssetDeploymentStateStolen;
            obj.Comentario = _OTRSOpions.AssetDeploymentStateStolen;
            obj.FechaMod = DateTime.Now;

            if (_OTRSContext.SaveChanges() > 0) {
                result = true;
            } else {
                result = false;
            }
            return result;

        }
    }
}
