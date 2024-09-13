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
                    
                    break;
                default:
                    Console.WriteLine($"Неизвестный аргумент: {args[0]}");
                    break;
            }
        }
    }

    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to Cocoa Laun! \nвведите $cocoalaun help чтобы получить справку по использованию программы");
        Console.WriteLine("Ver:" + versi);
        Console.WriteLine("CocoaLaun - Minecraft Server Launcher");
    }
}