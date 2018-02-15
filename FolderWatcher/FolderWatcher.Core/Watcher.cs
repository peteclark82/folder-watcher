using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace FolderWatcher.Core
{    
    public class Watcher : IWatcher
    {
        #region Public Properties
        [Description("The display name of the watcher, used to visually identify it.")]
        public string Title { get; set; }

        [Description("Represents whether or not the watcher is currently active.")]
        public bool Active { get; set; }

        [Browsable(false)]
        public ITrigger Trigger { get; set; }

        [Browsable(false)]
        public ITriggeredAction Action { get; set; }
        #endregion

        #region Private Variables
        private CancellationTokenSource _cancellationTokenSource;
        private LogManager _logger;
        #endregion

        public Watcher()
        {
            _logger = LogManager.Create("Watcher");
        }

        #region Public Methods
        public void Start()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Trigger.Create(() =>
            {
                Task.Run(() =>
                {
                    Action.Execute((error, output) =>
                    {
                        if (string.IsNullOrEmpty(error))
                        {
                            _logger.Info(output);
                        }
                        else
                        {
                            _logger.Error(error);
                        }
                    });
                }, _cancellationTokenSource.Token);                
            }, _cancellationTokenSource.Token);          
        }

        public void Stop()
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource = null;
            }

        }
        #endregion
    }
}