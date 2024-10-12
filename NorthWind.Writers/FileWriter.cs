﻿using NorthWind.Entities.ValueObject;

namespace NorthWind.Writers
{
    internal class FileWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            File.AppendAllText("AppLogs.txt",
              string.Format("FileWriter: {0}, {1}, {2}",
                action.CreateDateTime, action.User, action.Description));
        }
    }
}
