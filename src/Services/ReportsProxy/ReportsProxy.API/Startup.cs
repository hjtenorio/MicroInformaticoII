using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProxyKit;
using Serilog;
using System.Net;
using System.Net.Http;

namespace ReportsProxy.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();

            //var networkCredentials = Configuration.GetSection("GesRepNetworkCredentialsSettings").Get<GesRepNetworkCredentialsSettings>();
            //HttpMessageHandler CreatePrimaryHandler() {
            //    var clientHandler = new HttpClientHandler {
            //        Credentials = new NetworkCredential(networkCredentials.Username, networkCredentials.Password, networkCredentials.Domain),
            //        UseDefaultCredentials = false
            //    };
            //    return clientHandler;
            //}

            //services.AddProxy(httpClientBuilder =>
            //    httpClientBuilder.ConfigurePrimaryHttpMessageHandler(CreatePrimaryHandler)
            //);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseSerilogRequestLogging();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
            //var proxyUrl = Configuration.GetSection("GesRepProxySettings").Get<GesRepProxySettings>().ReportingServerBaseUrl;
            //var networkCredentials = Configuration.GetSection("GesRepNetworkCredentialsSettings").Get<GesRepNetworkCredentialsSettings>();
            //logger.LogInformation($"Using GESREP Proxy URL -> {proxyUrl}");
            //logger.LogInformation($"Using GESREP Network Credentials -> Username: {networkCredentials.Username} -- Password: {networkCredentials.Password} -- Domain: {networkCredentials.Domain}");
            //app.RunProxy(context => context.ForwardTo(proxyUrl).AddXForwardedHeaders().Send());
        }
    }
}