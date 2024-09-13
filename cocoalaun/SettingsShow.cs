namespace CocoaLaun;


public class SettingsShow
{
    public static string path_to_folder_server;
    public static void SettingsShw()
    {
        string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        
        path_to_folder_server = $"{homeDirectory}/myfolder";

        Console.WriteLine("Welcome to Global Settings cocoalaun! \n ");
        Console.WriteLine("\n 1. Path to Servers cocoalaun  = " + path_to_folder_server );
        
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
                validInput = true;
                switch (input)
                {
                    case 1:
                        string inputServer = Console.ReadLine();
                        path_to_folder_server = $"{homeDirectory}{inputServer}";
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
}