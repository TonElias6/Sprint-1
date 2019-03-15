using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vul twee getallen in!");
            Console.ReadLine();

            Console.Write("Vul getal 1 in ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vul getal 2 in ");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            double getal3 = getal1 + getal2;
            Console.WriteLine("Antwoord: " + getal1 + " + " + getal2 + " = " + Math.Round(getal3, 2));

            double getal4 = getal1 - getal2;
            Console.WriteLine("Antwoord: " + getal1 + " - " + getal2 + " = " + Math.Round(getal4, 2));

            double getal5 = getal2 - getal1;
            Console.WriteLine("Antwoord: " + getal2 + " - " + getal1 + " = " + Math.Round(getal5, 2));

            double getal6 = getal1 * getal2;
            Console.WriteLine("Antwoord: " + getal1 + " x " + getal2 + " = " + Math.Round(getal6, 2));

            double getal7 = getal1 / getal2;
            Console.WriteLine("Antwoord: " + getal1 + " / " + getal2 + " = " + Math.Round(getal7, 2));

            double getal8 = getal3 + getal4 + getal5 + getal6 + getal7;
            double getal9 = getal8 / getal1;
            double getal10 = getal8 / getal2;

            Console.WriteLine("Het getal delen door: " + getal1 + " = " + Math.Round(getal9, 2));
            Console.WriteLine("Het getal delen door: " + getal2 + " = " + Math.Round(getal10, 2));

            Console.ReadKey();

        }
    }
}