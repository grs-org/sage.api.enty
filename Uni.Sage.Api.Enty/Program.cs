using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace Uni.Sage.Api.Enty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(@"C:\logs\Sage-Api\log-.log", rollingInterval: RollingInterval.Day)
                .WriteTo.Console(Serilog.Events.LogEventLevel.Debug)
                .CreateLogger();

            Log.Information("#######   Starting up!  #######");

            try
            {
                CreateHostBuilder(args).Build().Run();

                Log.Information("#######  Stopped cleanly  #######");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "#######  Host terminated unexpectedly   #######");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}