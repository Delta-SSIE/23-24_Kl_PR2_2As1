using System;

namespace _070_Sude_nebo_liche
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který načte jedno číslo od uživatele a vypíše jestli je číslo sudé nebo liché.

            Console.Title = "Úloha 070 - Sudé nebo liché?";

            Console.Write("Zadej číslo: ");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo %2 == 0)
                Console.WriteLine($"Číslo {cislo} je sudé.");
            else
                Console.WriteLine($"Číslo {cislo} je liché.");                
        }
    }
}
