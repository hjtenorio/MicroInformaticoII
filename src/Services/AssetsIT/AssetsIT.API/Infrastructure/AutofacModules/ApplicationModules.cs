using AssetsIT.API.Configuration;
using AssetsIT.API.Extensions;
using AssetsIT.API.Services;
using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.SenderEmailAggregate;
using AssetsIT.Domain.AggregatesModel.ServiceAggregate;
using AssetsIT.Domain.AggregatesModel.StolenAlertAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AssetsIT.Domain.AggregatesModel.TrackingAggregate;
using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFRepositories;
using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EntityFramework.Repositories;
using AssetsIT.Infrastructure.Valtx.OTRS.OTRSClient;
using AssetsIT.Infrastructure.Valtx.SMTP.Client;
using Autofac;
using Identity.Infrastructure.Valtx.SMTP.Repositories;

namespace AssetsIT.API.Infrastructure.AutofacModules
{
    public class ApplicationModules : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder) 
        {
            builder.RegisterType<OTRSClientRest>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SMTPClient>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StolenAlertEFRepository>()
                .As<IStolenAlertRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AssetEFRepository>()
                .As<IAssetRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CustomerUserEFRepository>()
                .As<ICustomerUserRepository>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<SenderEmailRepository>()
                .As<ISenderEmailRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ServiceEFRepository>()
                .As<IServiceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TicketEFRepository>()
                .As<Domain.AggregatesModel.TicketAggregate.ITicketRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TrackingEFRepository>()
                .As<ITrackingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SmtpService>()
                .As<ISmtpService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OtrsCredencialsService>()
                .As<IOtrsCredencialsService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ConvertFileExtensions>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OtrsConnectionStrings>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmailSettings>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TicketSettings>()
                .InstancePerLifetimeScope();
        }
    }
}