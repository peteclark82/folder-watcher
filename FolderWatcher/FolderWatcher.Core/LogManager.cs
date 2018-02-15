using System;
using System.Data.Common;

namespace FolderWatcher.Core
{
    public class LogManager
    {
        private static ILogger _logger;

        private readonly string _source;

        public static void SetLogger(ILogger logger)
        {
            _logger = logger;
        }

        public static LogManager Create(string source)
        {
            return new LogManager(source);
        }

        private LogManager(string source)
        {
            _source = source;
        }

        public void Info(string message, params object[] args)
        {
            Info(string.Format(message, args));
        }
        public void Info(string message)
        {
            _logger.Info(_source, message);
        }

        public void Error(string message, Exception exception)
        {
            Error(string.Format("{0}\nException : {1}\nMessage : {2}\nStackTrace : {3}", message, exception.GetType(), exception.Message, exception.StackTrace));
        }
        public void Error(string message)
        {
            _logger.Error(_source, message);
        }

        public void Debug(string message, params object[] args)
        {
            Debug(string.Format(message, args));
        }
        public void Debug(string message)
        {
            _logger.Debug(_source, message);
        }
    }
}