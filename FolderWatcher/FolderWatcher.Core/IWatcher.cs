using System;

namespace FolderWatcher.Core
{
    public interface IWatcher
    {
        string Title { get; set; }
        void Start();
        void Stop();
    }
}
