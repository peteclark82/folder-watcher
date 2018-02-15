using System;
using System.Threading;

namespace FolderWatcher.Core
{
    public interface ITrigger
    {
        void Create(Action action, CancellationToken token);
    }
}
