namespace FolderWatcher.Core
{
    public interface ILogger
    {
        void Info(string source, string message);
        void Error(string source, string message);
        void Debug(string source, string message);
    }
}