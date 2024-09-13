using System;
using CocoaLaun;

class Program
{
    public static string versi = " beta 0.0.1";
    
    static void Main(string[] args)
    {
        // Проверка наличия аргументов
        if (args.Length == 0)
        {
            ShowWelcomeMessage();
        }
        else
        {
            // Обработка переданных аргументов
            switch (args[0].ToLower())
            {
                case "help":
                    HelpShow.ShowHelp(); // Вызов метода из HelpShow.cs
                    break;
                case "settings":
                    SettingsShow.SettingsShw();
                    break;
                default:
                    Console.WriteLine($"Invalid argument: {args[0]}");
                    break;
            }
        }
    }

    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to Cocoa Laun! \nget help $ cocoalaun for help on the program used");
        Console.WriteLine("Ver:" + versi);
        Console.WriteLine("CocoaLaun - Minecraft Server Launcher");
        Console.WriteLine("\n By kabancik166");
    }
}