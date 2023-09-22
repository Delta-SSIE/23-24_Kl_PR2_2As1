using System;

namespace _050_Vetsi_cislo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sestavte algoritmus, který načte dvě čísla od uživatele a vypíše to větší.

            Console.Title = "Úloha 050 - Větší číslo";

            Console.Write("Zadej první číslo: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a > b) 
                Console.WriteLine($"{a} je větší než {b}.");
            else if (a < b)
                Console.WriteLine($"{a} je menší než {b}.");
            else
                Console.WriteLine("Obě čísla jsou shodná.");
        }
    }
}
