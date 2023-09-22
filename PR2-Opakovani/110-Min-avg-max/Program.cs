using System;

namespace _110_Min_avg_max
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sestavte algoritmus, který z deseti zadaných čísel vypíše součin těch, která jsou sudá a větší než deset.

            Console.Title = "Úloha 110 - Minimum / průměr / maximum";

            int n = 10;

            Console.WriteLine($"Zadej {n} čísel, já zjistím maximum, minimum a průměr");
            Console.WriteLine();

            double soucet = 0;
            double min = 0;
            double max = 0;


            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Zadej {i}. číslo: ");
                double cislo = double.Parse(Console.ReadLine());

                // při prvním průchodu nastavím max i min na zadané číslo - je první
                if (i == 1)
                {
                    min = cislo;
                    max = cislo;
                }

                if (cislo < min)
                    min = cislo;

                if (cislo > max)
                    max = cislo;

                soucet += cislo;
            }

            double prumer = soucet / n;

            Console.WriteLine();
            Console.WriteLine($"Minimum ze zadaných čísel bylo {min}, maximum {max} a průměr {prumer}.");
        }
    }
}
