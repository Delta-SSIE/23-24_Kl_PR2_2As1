using System;

namespace _120_Podmineny_soucin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který z deseti zadaných čísel vypíše součin těch, která jsou sudá a větší než deset.

            Console.Title = "Úloha 120 - Podmíněný součin";

            int n = 10;

            Console.WriteLine($"Zadej {n} čísel, já spočítám součin všech těch, která jsou sudá a větší než deset.");
            Console.WriteLine();

            double soucin = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Zadej {i+1}. číslo: ");
                double cislo = double.Parse(Console.ReadLine());

                if (cislo > 10 && cislo % 2 == 0)
                    soucin *= cislo;
            }

            Console.WriteLine();
            Console.WriteLine($"Součin všech čísel splňujících podmínky je {soucin}.");
        }
    }
}
