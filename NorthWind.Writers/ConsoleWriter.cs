
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;


namespace NorthWind.Writers;
internal class ConsoleWriter : IUserActionWriter
{   
    public void Write(UserAction action) 
    {
        Console.WriteLine("consoleWriter: {0}, {1}, {2}",
            action.CreateDateTime, action.User, action.Description);
    }

}
