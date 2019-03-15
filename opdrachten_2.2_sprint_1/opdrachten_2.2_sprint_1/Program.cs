using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hallo!, Welkom op de BMI tester!");
            Console.ReadLine();

            Console.Write("Vul je gewicht (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vul je lengte (m): ");
            double Height = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (Height * Height);
            Console.WriteLine("Jou BMI: " + Math.Round(BMI, 2));

            if (BMI < 18)
                Console.WriteLine("Je bent te mager, eet wat meer! Scharminkel.");
            else
                if (BMI <= 29)
                Console.WriteLine("Je bent normaal. Goed bezig!");
            else
                if (BMI > 30)
                Console.WriteLine("Je bent veel te dik, eet is wat minder! DIKKE.");

            Console.ReadKey();

        }
    }
}