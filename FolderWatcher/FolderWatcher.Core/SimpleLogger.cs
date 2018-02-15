using System;

namespace FolderWatcher.Core
{
    public class SimpleLogger : ILogger
    {
        public event Action<string, string> InfoReceived;
        public event Action<string, string> ErrorReceived;
        public event Action<string, string> DebugReceived;

        public void Info(string source, string message)
        {
            if (InfoReceived != null)
            {
                InfoReceived(source, message);
            }
        }

        public void Error(string source, string message)
        {
            if (ErrorReceived != null)
            {
                ErrorReceived(source, message);
            }
        }

        public void Debug(string source, string message)
        {
            if (DebugReceived != null)
            {
                DebugReceived(source, message);
            }
        }
    }
}