using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using System.Text;
using System.Threading.Tasks;

namespace AssetsIT.BackgroundTasks.Services
{
    public interface ISmtpService
    {
        Task<bool> SendUserStaffTerminationNotificationEmail(CustomerUserData user, long nroEmployeesTermination);
        Task<bool> SendEmailAdministratorSystem(StringBuilder result, string subject);
    }
}
