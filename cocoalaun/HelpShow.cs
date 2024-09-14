namespace CocoaLaun;

public class HelpShow
{
    public static void ShowHelp()
    {
        Console.WriteLine("Welcome to Help Cocoa Laun!");
        Console.WriteLine("\n Global Commands: ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(" -$  cocoalaun help   (Help to cocoalaun) \n -$  cocoalaun -settings   (Global Settings :/) \n -$  cocoalaun -version   (View version) \n -$  cocoalaun -stopall   (Save and stop all servers)");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(" Server Global Commands: ");
        Console.WriteLine(" -$  cocoalaun servers -list   (list servers) \n -$  cocoalaun servers --{id server} -open   (Open directory server) \n -$  cocoalaun servers -new   (Create new Server) \n -$  cocoalaun servers -import   (Importing Server) \n -$  cocoalaun servers --{server-id} -export   (Export {server-id}.zip to /home)  \n -$  cocoalaun servers --{id server} -delete   (Delete server) \n -$  cocoalaun servers -deleteall   (Delete all servers) \n -$  cocoalaun servers -settings   (Global settings servers)");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(" Server Editor Commands:  ");
        Console.WriteLine(" -$  cocoalaun servers editor --{id server}   (Menu Editor Server) \n -$  cocoalaun servers editor -leave   (Leave is Editor Server) ");
        Console.WriteLine("--------------------------------------------------");
        
        Console.WriteLine("\n If you have any bugs/questions/ideas, feel free to comment on this project on Github ");
        Console.WriteLine("\n By Kabancik166.");
    }
}