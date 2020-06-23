using AssetsIt.BackgroundTasks.Configuration;
using AssetsIt.BackgroundTasks.Infrastructure.Hangfire;
using AssetsIT.BackgroundTasks.Infrastructure.AutofacModules;
using AssetsIT.BackgroundTasks.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Hangfire;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace AssetsIt.BackgroundTasks
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }


        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();
            services.AddCustomConfiguration(Configuration);
            services.AddHangfireIntegration(Configuration);

        }

        public void ConfigureContainer(ContainerBuilder builder) {
            builder.RegisterModule(new BackgroundTasksModule());
        }

        public void Configure(IApplicationBuilder app,
                                IRecurringJobManager recurringJobs,
                                IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();

            GlobalConfiguration.Configuration.UseAutofacActivator(this.AutofacContainer);

            app.UseRouting();

            app.UseHangfireDashboard();

            var CreateTerminatedUserStaffAssetsReturnTicketsTaskRecurringJobId
                = NewId.Next().ToString();

            var SendUserStaffTerminationNotificationTaskRecurringJobId
                = NewId.Next().ToString();

            var CreateTerminatedUserStaffAssetsReturnTicketsTaskCronExpression =
                Configuration.GetValue<string>("CreateTerminatedUserStaffAssetsReturnTicketsTaskCronExpression");

            var SendUserStaffTerminationNotificationTaskCronExpression =
                Configuration.GetValue<string>("SendUserStaffTerminationNotificationTaskCronExpression");


            recurringJobs.AddOrUpdate<CreateTerminatedUserStaffAssetsReturnTicketsTask>(
                CreateTerminatedUserStaffAssetsReturnTicketsTaskRecurringJobId,
                task => task.ExecuteAsync(), CreateTerminatedUserStaffAssetsReturnTicketsTaskCronExpression);


            recurringJobs.AddOrUpdate<SendUserStaffTerminationNotificationTask>(
                SendUserStaffTerminationNotificationTaskRecurringJobId,
                task => task.ExecuteAsync(),
                SendUserStaffTerminationNotificationTaskCronExpression);


            app.UseSerilogRequestLogging();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }

    }


}
