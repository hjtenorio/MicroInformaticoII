using AssetsIT.API.Infrastructure.AutofacModules;
using AssetsIT.API.Services;
using Autofac;
using Identity.API.Configuration;
using Identity.API.Models;
using Identity.API.Services;
using Identity.Infrastructure.IdentityServer4.Configuration;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System;
using System.Text;

namespace Identity.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers()
                .AddNewtonsoftJson();
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Identity API", Version = "v1" }); });
            services.AddCustomConfiguration(Configuration);
            services.AddTransient<ITokenProviderService, IdentityTokenService>();
            services.AddTransient<IResourceOwnerPasswordValidator, ResourceOwnerPasswordValidatorService>();

            services.AddIdentityServer(options => options.IssuerUri = Configuration.GetValue<string>("IdentityServer4:IssuerUri"))
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryClients(Config.GetClients(Configuration))
                .AddDeveloperSigningCredential(false);

           

            services.AddAuthentication(options => {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options => {
                options.TokenValidationParameters = new TokenValidationParameters {
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    LifetimeValidator = (notBefore, expires, securityToken, validationParameter) =>
                    expires >= DateTime.UtcNow
                };

                options.RequireHttpsMetadata = false;
                options.Authority = Configuration.GetValue<string>("IdentityServer4:OptionsAuthority");
            });

            services.AddCorsPolicy();
        }

        public void ConfigureContainer(ContainerBuilder builder) {
            builder.RegisterModule(new ApplicationModules());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "Identity API V1");
                c.RoutePrefix = string.Empty;
            });
            app.UseExceptionHandler(errorApp => {
                errorApp.Run(async context => {
                    context.Response.StatusCode = 500; // or another Status
                    context.Response.ContentType = "application/json";
                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null) {
                        var ex = error.Error;
                        await context.Response.WriteAsync(new ErrorDTO() {
                            Code = 500,
                            Message = ex.Message // or your custom message
                        }.ToString(), Encoding.UTF8);
                    }
                });
            });
            app.UseSerilogRequestLogging();
            app.UseCors("CorsPolicy");
            app.UseStaticFiles();
            app.UseRouting();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }

    internal static class ExtensionMethods
    {
        public static IServiceCollection AddCustomConfiguration(this IServiceCollection services, IConfiguration configuration) {
            services.AddOptions();
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"))
                .Configure<ResetPasswordSettings>(configuration.GetSection("ResetPasswordSettings"))
                .Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            return services;
        }

        public static IServiceCollection AddCorsPolicy(this IServiceCollection services) {
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
    }
}