using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObject;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Core.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writers) : IAppLogger
    {
        public void WriteLog(string message)
        {
            UserAction log = new UserAction("System", message);
            foreach (var writer in writers)
                writer.Write(log);
        }
    }
}