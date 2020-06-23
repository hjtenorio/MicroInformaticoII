using AssetsIT.BackgroundTasks.Services;
using AssetsIT.BackgroundTasks.Tasks;
using AssetsIT.Domain.AggregatesModel.SenderEmailAggregate;
using AssetsIT.Infrastructure.Valtx.SMTP.Client;
using Autofac;
using Identity.Infrastructure.Valtx.SMTP.Repositories;

namespace AssetsIT.BackgroundTasks.Infrastructure.AutofacModules
{
    public class BackgroundTasksModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder) {
            builder.RegisterType<CreateTerminatedUserStaffAssetsReturnTicketsTask>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SendUserStaffTerminationNotificationTask>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SMTPClient>()

                .InstancePerLifetimeScope();
            builder.RegisterType<SmtpService>()
                .As<ISmtpService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SenderEmailRepository>()
                .As<ISenderEmailRepository>()
                .InstancePerLifetimeScope();

        }
    }
}