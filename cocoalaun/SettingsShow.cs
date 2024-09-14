
namespace CocoaLaun
{
    public class SettingsShow
    {
        public static string PathToFolderServer;
        
        public static void SettingsShw()
        {
            string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
            PathToFolderServer = ConfigManager.GetConfigValue("path_to_folder_servers");

            Console.WriteLine("Welcome to Global Settings cocoalaun! \n");
            Console.WriteLine("\n 1. Path to Servers cocoalaun = " + PathToFolderServer + 
                " (To change the path, enter only the part after /home/username. For example, for the path /home/username/Desktop, simply enter /Desktop. Other methods of specifying the path are not supported.)");
            Console.WriteLine("14. Restart Config    (Restart config:/)");
            Console.WriteLine("15. Exit Settings    (Exit Settings:/)");

            int input;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("\nPress any number: ");
                string inputString = Console.ReadLine();

                if (string.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Exiting...");
                    return;
                }
                
                if (int.TryParse(inputString, out input))
                {
                    switch (input)
                    {
                        case 1:
                            while (true)
                            {
                                Console.WriteLine("\nEnter the new path (e.g., /Desktop): ");
                                string inputServer = Console.ReadLine();

                                if (string.IsNullOrEmpty(inputServer))
                                {
                                    Console.WriteLine("No input provided. Exiting...");
                                    return;
                                }

                                if (IsPathValid(inputServer))
                                {
                                    string escapedPath = EscapeSpaces(inputServer);
                                    ConfigManager.UpdateConfig("path_to_folder_servers", $"{homeDirectory}{escapedPath}");
                                    Console.WriteLine("\nPath successfully updated to: " + PathToFolderServer);
                                    
                                    SettingsShw();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid path syntax. Please try again.");
                                }
                            }
                            
                        case 14:
                            ConfigManager.CreateConfig();
                            SettingsShw();
                            break;
                        case 15:
                            validInput = true;
                            break;
                        default:
                            Console.WriteLine("\nError: Invalid input.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.");
                }
            }
        }

        public static bool IsPathValid(string path)
        {
            char[] invalidChars = Path.GetInvalidPathChars();

            foreach (char c in invalidChars)
            {
                if (path.Contains(c) && c != ' ')
                {
                    return false;
                }
            }

            if (!path.StartsWith("/"))
            {
                return false;
            }

            if (path.EndsWith("\\"))
            {
                return false;
            }

            return true;
        }

        public static string EscapeSpaces(string path)
        {
            return path.Replace(" ", "\\ ");
        }
    }
}
