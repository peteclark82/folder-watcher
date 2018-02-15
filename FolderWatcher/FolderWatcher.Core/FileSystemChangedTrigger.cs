using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Threading;
using System.Windows.Forms.Design;

namespace FolderWatcher.Core
{
    public class FileSystemChangedTrigger : ITrigger
    {
        private readonly LogManager _logger;

        [Description("The full directory path to monitor for changes.")]
        [EditorAttribute(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public string FilePath { get; set; }

        [Description("When enabled, raises only a single event for multiple calls within a given time period.")]
        public bool LimitCalls { get; set; }

        [Description("If LimitCalls is enabled, this is the time period (in milli-seconds) for multiple calls to count as a single.")]
        public int LimitTimePeriod { get; set; }

        public FileSystemChangedTrigger()
        {
            _logger = LogManager.Create("FileSystemChangedTrigger");
            LimitCalls = true;
            LimitTimePeriod = 1000;
        }

        public void Create(Action action, CancellationToken token)
        {         
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = FilePath;
            watcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;

            var callAction = LimitCalls ? CallThrottler.Create(LimitTimePeriod, action) : action;

            watcher.Changed += (source, e) =>
            {
                _logger.Debug("Triggered by change, type : {0}, path : {1}", e.ChangeType, e.FullPath); 
                callAction();
            };
            watcher.Created += (source, e) =>
            {
                _logger.Debug("Triggered by creation, type : {0}, path : {1}", e.ChangeType, e.FullPath); 
                callAction();
            };
            watcher.Deleted += (source, e) =>
            {
                _logger.Debug("Triggered by deletion, type : {0}, path : {1}", e.ChangeType, e.FullPath); 
                callAction();
            };
            watcher.Renamed += (source, e) =>
            {
                _logger.Debug("Triggered by rename, type : {0}, path : {1}", e.ChangeType, e.FullPath); 
                callAction();
            };
            watcher.Error += (source, e) =>
            {
                _logger.Error("Error with file system watcher.", e.GetException());
                
                watcher.EnableRaisingEvents = false;
                _logger.Info("Waiting for network connection to be re-estabilished...");
                new NetworkReconnectedWaiter(FilePath, () =>
                {
                    watcher.EnableRaisingEvents = true;
                    _logger.Info("Network connection re-estabilished.");
                });
            };

            watcher.EnableRaisingEvents = true;

            token.Register(() =>
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
            });
        }
    }
}