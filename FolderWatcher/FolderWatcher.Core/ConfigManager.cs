using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace FolderWatcher.Core
{
    public class ConfigManager
    {
        private readonly string _configFilename;
        private readonly DataContractSerializer _serializer;

        public ConfigManager(string configFilename)
        {
            _configFilename = configFilename;
            _serializer = new DataContractSerializer(typeof(List<AppConfig>), new[] { typeof(Watcher), typeof(FileSystemChangedTrigger), typeof(RunBatchFileAction) });
        }

        public AppConfig Load()
        {
            AppConfig config = null;
            if (File.Exists(_configFilename))
            {
                using (var configStream = XmlReader.Create(_configFilename))
                {
                    config = _serializer.ReadObject(configStream) as AppConfig;    
                }                
            }
            return config;
        }

        public void Save(AppConfig config)
        {            
            var settings = new XmlWriterSettings { Indent = true };
            using (var configStream = XmlWriter.Create(_configFilename, settings))
            {
                _serializer.WriteObject(configStream, config);    
            }            
        }
    }
}
