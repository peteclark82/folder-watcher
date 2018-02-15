using System;

namespace FolderWatcher.Core
{
    public interface ITriggeredAction
    {
        void Execute(Action<string, string> finishedCallback);
    }
}
