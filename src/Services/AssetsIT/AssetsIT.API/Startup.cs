using AssetsIT.API.Extensions;
using AssetsIT.API.Infrastructure.AutofacModules;
using AssetsIT.API.Infrastructure.ExtensionMethods;
using AssetsIT.API.Infrastructure.GESREP;
using AssetsIT.API.Services;
using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using NLog;
using Serilog;
using System.IO;
using Valtx.Services.AssetsIT.API.Integrations.GESREP;

namespace AssetsIT.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddCustomMvc();
            services.AddCustomConfiguration(Configuration);
            services.AddCustomCors();
            services.AddCustomAuthentication(Configuration);
            services.AddCustomDbContext(Configuration);
            services.AddCustomSwagger(Configuration);
            services.AddSingleton<ILoggerManagerService, LoggerManagerService>();
            services.AddAutoMapper(typeof(Startup));
            services.AddGESREPIntegration(Configuration);
        }

        public void ConfigureContainer(ContainerBuilder builder) {
            builder.RegisterModule(new ApplicationModules());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            ILoggerManagerService logger, IOptionsMonitor<GESREPConfig> GESREPConfigAccessor) {

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "Identity API V1");
                c.RoutePrefix = string.Empty;
            });
            app.ConfigureCustomExceptionMiddleware();
            app.UseSerilogRequestLogging();
            app.UseCors("CorsPolicy");
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            app.UseGESREPProxy(GESREPConfigAccessor.CurrentValue);
        }
    }
}