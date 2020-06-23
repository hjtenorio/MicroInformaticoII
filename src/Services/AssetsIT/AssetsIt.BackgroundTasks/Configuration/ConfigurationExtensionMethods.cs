using AssetsIT.BackgroundTasks.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AssetsIt.BackgroundTasks.Configuration
{
    internal static class ConfigurationExtensionMethods
    {
        public static IServiceCollection AddCustomConfiguration
            (this IServiceCollection services, IConfiguration configuration) {

            services.AddOptions();
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"))
                .Configure<UrlSpa>(configuration.GetSection("UrlSpa"));

            return services;
        }



    }
}
