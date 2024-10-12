using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObject;

namespace NorthWind.Writers
{
    internal class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Console.WriteLine("ConsolerWriter: {0}, {1}, {2}",
                action.CreateDateTime, action.User, action.Description);

        }

    }
}