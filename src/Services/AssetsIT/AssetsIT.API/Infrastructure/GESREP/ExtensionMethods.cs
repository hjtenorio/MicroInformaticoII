
using AspNetCore.Proxy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http;
using Valtx.Services.AssetsIT.API.Integrations.GESREP;

namespace AssetsIT.API.Infrastructure.GESREP
{
    public static class ExtensionMethods
    {
        public static IServiceCollection AddGESREPIntegration(this IServiceCollection services, IConfiguration configuration) {
            services.Configure<GESREPConfig>(configuration);
            services.AddHttpClient("GESREP")
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler {
                    Credentials = new NetworkCredential(
                        configuration.Get<GESREPConfig>().AccountUsername,
                        configuration.Get<GESREPConfig>().AccountPassword,
                        configuration.Get<GESREPConfig>().AccountDomain),
                    UseDefaultCredentials = false
                });


            services.AddProxies();
            return services;
        }

        public static IApplicationBuilder UseGESREPProxy(this IApplicationBuilder app, GESREPConfig configuration) {
            app.UseProxies(proxies => proxies.Map("ReportServer_EDI_DESA/{**rest}", proxy => proxy
                .UseHttp((context, args) =>
                    $"{configuration.ReportViewerURL}/{args["rest"]}{context.Request.QueryString.Value}",
                    options => options.WithHttpClientName("GESREP"))));


            return app;
        }


    }
}




//var networkCredentials = configuration.GetValue<string>[]("GesRepNetworkCredentialsSettings").Get<GesRepNetworkCredentialsSettings>();
//HttpMessageHandler CreatePrimaryHandler() {
//    var clientHandler =
//                    return clientHandler
//}

//services.AddProxy(httpClientBuilder =>
//        httpClientBuilder.ConfigurePrimaryHttpMessageHandler(CreatePrimaryHandler)
//    );
//    return services;
//}