
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using var AppHost = Builder.Build();


//IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Aplicacion started.");

ProductService service = AppHost.Services.GetRequiredService<ProductService>();
service.Add("Demo", "Azucar refinada");

