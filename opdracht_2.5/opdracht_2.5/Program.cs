using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul je volledige naam in!");
            string naam = Console.ReadLine();
            Console.WriteLine("Welkom op de site, " + naam);
            Console.ReadLine();

            Console.ReadKey();

            Console.Write("Wat is de waarde van de auto!");
            Console.ReadLine();
            Console.Write("In euro: ");
            double waarde = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            double lakw = waarde * 0.05;
            double lerenw = waarde * 0.05;
            double helew = waarde + lakw + lerenw + 1000;
            Console.WriteLine("Lak kosten: " + lakw + ",- euro");
            Console.WriteLine("Leren kosten: " + lerenw + ",- euro");
            Console.WriteLine("Automaat kosten " + "1000,- euro");
            Console.ReadLine();
            Console.WriteLine("De gehele kosten zijn: " + helew + ",- euro");

            Console.ReadKey();




        }
    }
}
