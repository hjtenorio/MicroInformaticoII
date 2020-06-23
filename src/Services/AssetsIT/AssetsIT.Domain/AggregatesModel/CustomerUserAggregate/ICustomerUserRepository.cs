using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.Domain.AggregatesModel.CustomerUserAggregate
{
    public interface ICustomerUserRepository
    {
        Task<CustomerUserData> GetCustomerUserByDni(string nroDni);
        Task<CustomerUserData> GetCustomerUserByCip(string nroCip);
        Task<IEnumerable<CustomerUserData>> GetListCustomerUserTermination(CustomerCessationSearch search);
        Task<IEnumerable<CustomerUserData>> GetListCustomerUserTerminationNotRenew(string initialNameBusinness);
        Task<IEnumerable<CustomerUserData>> GetListCustomerUserChief(string initialNameBusinness);
        bool UpdateBulkListCustomersCessation(List<CustomerCessationUpdate> customer);
        bool UpdateCustomerUserAssetReturn(int userId);
    }
}
