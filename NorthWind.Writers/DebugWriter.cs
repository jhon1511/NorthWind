using NorthWind.Entities.ValueObject;

namespace NorthWind.Writers
{
    internal class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Debug.WriteLine("ConsolerWriter: {0}, {1}, {2}",
                    action.CreateDateTime, action.User, action.Description);

        }

    }
}
