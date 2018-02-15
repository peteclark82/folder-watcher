using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Win32;

namespace FolderWatcher.Core
{
    [DataContract]
    public class AppConfig
    {
        [DataMember]
        public List<IWatcher> Watchers { get; set; }

        [DataMember]
        public bool AutoStartWatchers { get; set; }

        public bool LaunchOnWindowsStartUp
        {
            get
            {
                var registryKey = Registry.CurrentUser.OpenSubKey(AppRegKeyPath, true);
                return registryKey.GetValue(AppRegKeyName) != null;
            }            
        }

        private const string AppRegKeyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private const string AppRegKeyName = "FolderWatcher";


        public AppConfig()
        {
            Watchers = new List<IWatcher>();
        }

        public AppConfig(List<IWatcher> watchers)
        {
            Watchers = watchers;
        }

        public void ActivateLaunchOnWindowsStartUp(string executeablePath)
        {
            var registryKey = Registry.CurrentUser.OpenSubKey(AppRegKeyPath, true);
            registryKey.SetValue(AppRegKeyName, executeablePath);
        }

        public void DeactivateLaunchOnWindowsStartUp()
        {
            var registryKey = Registry.CurrentUser.OpenSubKey(AppRegKeyPath, true);
            if (registryKey.GetValue(AppRegKeyName) != null)
            {
                registryKey.DeleteValue(AppRegKeyName);
            }
        }
    }
}
