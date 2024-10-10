
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;


IUserActionWriter Writer = new DebugWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplicacion started.");

ProductService service = new ProductService(Writer);
service.Add("Demo", "Azucar refinada");

