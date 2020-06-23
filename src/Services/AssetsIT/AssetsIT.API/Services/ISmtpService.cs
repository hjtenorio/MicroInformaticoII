using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetsIT.API.Services
{
    public interface ISmtpService
    {
        Task<bool> SendEmailCreateTicket(CustomerUserData user, string nroTicket);
        Task<bool> SendEmailCreateTicketMultipleReceivers(List<CustomerUserData> user, string nroTicket);
        Task<bool> SendUserStaffTerminationNotificationEmail(CustomerUserData user, int nroEmployeesTermination);
    }
}
