using System;

namespace Opdracht3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, Check hier hoe oud je bent!");

            Console.WriteLine("Vul je geboortedatum in (Zoals dit, 20/02/2001)");

            DateTime bday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;

            if (bday > today.AddYears(-age))
                age--;

            Console.WriteLine(age + " Jaar oud");
            Console.ReadLine();



        }
    }
}