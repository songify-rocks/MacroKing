using System;
using System.IO;
using System.Reflection;

namespace MacroKing.General
{
    public class PathManager
    {
        public string StartupDirectory => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public string LogDirectory
        {
            get
            {
                string logPath = Path.Combine(StartupDirectory, "Log");
                if (!File.Exists(logPath)) { Directory.CreateDirectory(logPath); }
                return logPath;
            }
        }

        public string ConfigurationDirectory
        {
            get
            {
                string configPath = Path.Combine(StartupDirectory, "Configuration");
                if (!File.Exists(configPath)) { Directory.CreateDirectory(configPath); }
                return configPath;
            }
        }

        public string ConfigurationPath => Path.Combine(ConfigurationDirectory, "Configuration.json");

        public string KeyboardConfigPath => Path.Combine(ConfigurationDirectory, "Keyboards.json");

        public string LogFilePath => Path.Combine(LogDirectory, $"{DateTime.Now.ToString("dd.MM.yyyy")} - Log.txt");
    }
}
