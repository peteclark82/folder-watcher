using System;
using System.Timers;

namespace FolderWatcher.Core
{
    public static class CallThrottler
    {
        public static Action Create(int throttleTimePeriod, Action realAction)
        {
            var logger = LogManager.Create("CallThrottler");
            Timer timer = null;
            var callCount = 0;

            Action throttledAction = () =>
            {
                if (timer != null)
                {                     
                    callCount++;
                    logger.Debug("Call has been throttled {0} time(s).", callCount);
                }
                else
                {
                    timer = new Timer(throttleTimePeriod);
                    timer.Elapsed += (sender, args) =>
                    {
                        timer.Stop();
                        timer.Dispose();
                        timer = null;
                        realAction();
                    };
                    timer.Start();
                    callCount = 1;
                    logger.Debug("Call throttler has been started for period of {0}ms.", throttleTimePeriod);
                }
            };

            return throttledAction;
        }
    }
}
