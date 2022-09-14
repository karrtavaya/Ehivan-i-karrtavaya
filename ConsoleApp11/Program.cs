using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine(lang);
            Console.WriteLine("Введите язык");
            string? lang = Console.ReadLine();
            //Console.ReadLine(lang);
            //string lang = "ua";

            

            switch (lang)
            {
                case "ru":
                    Console.WriteLine("Привет мир!");
                    break;
                case "en":
                    Console.WriteLine("Hello world!");
                    break;
                case "ua":
                    Console.WriteLine("Привiт народ!");
                    break;
                case "az":
                    Console.WriteLine("Salam dunya!");
                    break;
                default:
                    Console.WriteLine("Локализация не найдена!");
                    break;

            }
        }
    }
}
