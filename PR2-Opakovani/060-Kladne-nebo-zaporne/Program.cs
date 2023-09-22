using System;

namespace _060_Kladne_nebo_zaporne
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus, který načte jedno číslo od uživatele a vypíše jestli je kladné, záporné nebo nulové.

			Console.Title = "Úloha 060 - Kladné nebo záporné?";

			Console.Write("Zadej číslo: ");
			double cislo = double.Parse(Console.ReadLine());

            if (cislo > 0)
                Console.WriteLine($"Číslo {cislo} je větší než nula.");
            else if (cislo < 0)
                Console.WriteLine($"Číslo {cislo} je menší než nula.");
            else
                Console.WriteLine("Byla zadána nula.");
        }
    }
}
