using System;

namespace _080_Je_cele
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který načte jedno číslo od uživatele a vypíše, zda je číslo celočíselné nebo desetinné.

            Console.Title = "Úloha 080 - je celé?";

            Console.Write("Zadej číslo: ");
            ; double cislo = double.Parse(Console.ReadLine()); //pozor, int by byl celý vždy, to jsou z definice celá čísla, jiná obsahovat nemůže

            if (cislo % 1 == 0)
                Console.WriteLine($"Číslo {cislo} je celé.");
            else
                Console.WriteLine($"Číslo {cislo} není celé.");
        }
    }
}
