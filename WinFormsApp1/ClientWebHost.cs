using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Aida.Sdk.Mini;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Aida.Samples.WebhooksReceiverConsole;
using DemoApplication;

namespace WinFormsApp1;

public class ClientWebHost
{
    public IHostBuilder CreateHost(string ipAddress, int mockDuration, int port = 7654)
    {
        string paramMock = "--MockEncodingDuration=00:00:02";
        string paramPort = "--Port={port}";
        string[] paramHost = new string[] { paramMock, paramPort };
        
        // var builder = WebApplication.CreateBuilder(paramHost);
        //
        // // Add services to the container.
        // builder.Services.AddAuthorization();
        //
        // // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        // builder.Services.AddEndpointsApiExplorer();
        // builder.Services.AddSwaggerGen();
        // var app = builder.Build();
        //
        // // Configure the HTTP request pipeline.
        // if (app.Environment.IsDevelopment())
        // {
        //     app.UseSwagger();
        //     app.UseSwaggerUI();
        // }
        //
        // app.Use(req =>
        // {
        //     Console.WriteLine("Mio middleware");
        //     return req;
        // });
        //
        // app.UseHttpsRedirection();
        // app.UseAuthorization();
        //
        // var summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };
        //
        // app.MapGet("/weatherforecast", (HttpContext _) =>
        //     {
        //         var forecast = Enumerable.Range(1, 5).Select(index =>
        //                 new WeatherForecast
        //                 {
        //                     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //                     TemperatureC = Random.Shared.Next(-20, 55),
        //                     Summary = summaries[Random.Shared.Next(summaries.Length)]
        //                 })
        //             .ToArray();
        //         return forecast;
        //     })
        //     .WithName("GetWeatherForecast")
        //     .WithOpenApi();
        //
        // app.Run();
        
        
        var configuration = new ConfigurationBuilder()
            .Build();
        
        Console.WriteLine($"Server listening on port: {configuration.GetValue("Port", 7654)}");
        
        // This is just boilerplate to setup ASP .NETCore
        // the startup class is used by the dependency injection system
        // to configure the object dependency graph of the application
        return Host
            .CreateDefaultBuilder(paramHost)
            // allow to kill the app with CTRL+C
            // .UseConsoleLifetime()
            // configure the web stack
            .ConfigureWebHostDefaults(builder =>
            {
                builder.ConfigureAppConfiguration(config => config.AddCommandLine(paramHost))
                    // configure serilog for nicer console logging
                    // .UseSerilog((c, loggerConfig) =>
                    // {
                    //     loggerConfig
                    //         .ReadFrom.Configuration(c.Configuration)
                    //         .Enrich.FromLogContext();
                    // })
                    .UseUrls($"http://{ipAddress}:{configuration.GetValue("Port", 7654)}")
                    // configure services and middleware pipeline
                    .UseStartup<Startup>();
            });
    }

    public async void StartWebHook()
    {
        string hostIpAddress = FormMain.GetLocalIPAddress();// "192.168.3.216";
        var host = CreateHost(hostIpAddress, 4);
        await host.RunConsoleAsync();
    }
}