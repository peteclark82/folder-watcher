using System;
using System.IO;
using System.Timers;

namespace FolderWatcher.Core
{
    public class NetworkReconnectedWaiter
    {
        private readonly string _filePath;
        private readonly Action _action;

        private Timer _timer;

        public NetworkReconnectedWaiter(string filePath, Action action)
        {
            _filePath = filePath;
            _action = action;

            _timer = new Timer(1000);
            _timer.Elapsed += TimerOnElapsed;
            _timer.Start();            
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (Directory.Exists(_filePath))
            {
                _action();
                _timer.Stop();
                _timer.Elapsed -= TimerOnElapsed;
                _timer.Dispose();
                _timer = null;
            }  
        }
    }
}