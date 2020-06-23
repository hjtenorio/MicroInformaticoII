using AssetsIt.BackgroundTasks.Configuration;
using Hangfire;
using Hangfire.Storage.SQLite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AssetsIt.BackgroundTasks.Infrastructure.Hangfire
{
    internal static class HangfireExtensionMethods
    {
        public static IServiceCollection AddHangfireIntegration
            (this IServiceCollection services, IConfiguration configuration) {

            GlobalConfiguration.Configuration.UseSQLiteStorage();
            services.Configure<BackgroundTaskSettings>(configuration);
            services.AddHangfire(configuration => configuration
                        .UseSimpleAssemblyNameTypeSerializer()
                        .UseRecommendedSerializerSettings()
                        .UseSQLiteStorage());
            services.AddHangfireServer();

            return services;
        }
    }
}
