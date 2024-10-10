
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

IUserActionWriter Writer = new default;

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplicacion started.");

