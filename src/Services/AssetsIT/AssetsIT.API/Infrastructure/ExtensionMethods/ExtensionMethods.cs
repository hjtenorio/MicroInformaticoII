using AssetsIT.Infrastructure.Valtx.OTRS;
using global::AssetsIT.API.Configuration;
using global::AssetsIT.Infrastructure.Valtx.OTRS.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace AssetsIT.API.Infrastructure.ExtensionMethods
{
    public static class ExtensionsMethods
    {
        public static IServiceCollection AddCustomMvc(this IServiceCollection services) {
            services
                .AddMvcCore()
                .AddCors()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services
                .AddControllers()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            return services;
        }

        public static IServiceCollection AddCustomConfiguration(this IServiceCollection services, IConfiguration configuration) {
            services.AddOptions();

            services.Configure<OTRSOptions>(configuration);
            services.Configure<OtrsConnectionStrings>(configuration.GetSection("OtrsConnectionStrings"));
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.Configure<TicketSettings>(configuration.GetSection("TicketSettings"));

            return services;
        }

        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration) {
            //services
            //    .AddAuthentication("Bearer")
            //    .AddIdentityServerAuthentication(options => {
            //        options.Authority = configuration.GetValue<string>("IdentityServer4:OptionsAuthority");
            //        options.RequireHttpsMetadata = false;
            //        options.ApiName = "AssetsITClient";
            //    });
            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options => {
                options.Authority = configuration.GetValue<string>("IdentityServer4:OptionsAuthority");
                options.RequireHttpsMetadata = false;
                options.Audience = "AssetsITClient";
            });
            return services;
        }

        public static IServiceCollection AddCustomCors(this IServiceCollection services) {
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            return services;
        }

        public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration) {
            services.AddEntityFrameworkMySql()
              .AddDbContext<OTRSContext>(options => {
                  options.UseMySql(configuration.GetValue<string>("ConnectionStrings:MysqlDefaultConnection"));
              },
                  ServiceLifetime.Scoped
              );
            return services;
        }

        public static IServiceCollection AddCustomSwagger(this IServiceCollection services, IConfiguration configuration) {
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "Valtx Cloud - AssetsIT HTTP API",
                    Version = "v1",
                    Description = "The AssetsIT Service HTTP API"
                });
            });

            return services;
        }
    }
}