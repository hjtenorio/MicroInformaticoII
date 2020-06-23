using Autofac;
using Identity.API.Services;
using Identity.Domain.AggregatesModel.JwtTokenAggregate;
using Identity.Domain.AggregatesModel.SenderEmailAggregate;
using Identity.Infrastructure.Valtx.RAIS.Client;
using Identity.Infrastructure.Valtx.Repositories;
using Identity.Infrastructure.Valtx.SMTP.Client;
using Identity.Infrastructure.Valtx.SMTP.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.API.Infrastructure.AutofacModules
{
    public class ApplicationModules : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder) {
            //builder.RegisterType<Serilog>()
            //    .As<ILogger>()
            //    .InstancePerLifetimeScope();

            builder.RegisterType<RAISClient>()
                .InstancePerLifetimeScope();
            //BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            //EndpointAddress endpointAddress = new EndpointAddress(myOptions.Value.EndpointUrl);
            //wcfClient = new SimpleServiceClient(basicHttpBinding, endpointAddress);
            builder.RegisterType<SMTPClient>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SenderEmailRepository>()
                .As<ISenderEmailRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<JwtTokenRepository>()
                .As<IJwtTokenRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<IdentityService>()
                .As<IIdentityService>()
                .InstancePerLifetimeScope();
        }
    }
}