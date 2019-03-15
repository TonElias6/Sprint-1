using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Naam: Mohamed Yasin");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Straat: Wederiklaan 48A");
            Console.WriteLine("Adress: 9649DA Doplhia");
            Console.WriteLine("Leeftijd: 16");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}