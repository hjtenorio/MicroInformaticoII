using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;

namespace ReportsProxy.API
{
    public class Program
    {
        public static int Main(string[] args) {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
               .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
               .Enrich.FromLogContext()
               .WriteTo.Seq("http://localhost:5341")
               .WriteTo.Console()
               .CreateLogger();

            try {
                Log.Information("Starting web host");
                CreateHostBuilder(args).Build().Run();
                return 0;
            } catch (Exception ex) {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            } finally {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                })
                .UseSerilog();
    }
}