
namespace CocoaLaun
{
    public class ConfigManager
    {
        private static string _configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".cocoalaun");
        private static string _filePathServers = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

        private static readonly string[] DefaultConfig = 
        {
            $"path_to_folder_servers={_filePathServers}"
        };

        public static void CreateConfig()
        {
            
            File.WriteAllLines(_configFilePath, DefaultConfig);
        }

        public static void UpdateConfig(string key, string value)
        {
            EnsureConfigExists();

            var lines = File.ReadAllLines(_configFilePath);
            bool keyExists = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(key + "="))
                {
                    lines[i] = $"{key}={value}";
                    keyExists = true;
                    break;
                }
            }

            if (!keyExists)
            {
                using (StreamWriter sw = File.AppendText(_configFilePath))
                {
                    sw.WriteLine($"{key}={value}");
                }
            }
            else
            {
                File.WriteAllLines(_configFilePath, lines);
            }
        }

        public static string GetConfigValue(string key)
        {
            EnsureConfigExists();

            var lines = File.ReadAllLines(_configFilePath);
            foreach (var line in lines)
            {
                if (line.StartsWith(key + "="))
                {
                    return line.Substring(key.Length + 1);
                }
            }

            return null;
        }

        public static void EnsureConfigExists()
        {
            if (!File.Exists(_configFilePath))
            {
                CreateConfig();
            }
        }
    }
}