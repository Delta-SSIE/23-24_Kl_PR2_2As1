using System;

namespace _200_Min_avg_max_v_poli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který určí minimální, průměrné a maximální číslo nacházející se v poli a počty sudých a lichých čísel.

            Console.Title = "Úloha 200 - Minimum, průměr a maximum v poli";

            int[] pole = { -5, 3, 2, -3, 7, 0, 12, -1 };
            // int[] pole = {1, 3, 2, 1, 7, 0, 12, -1};
            // int[] pole = {-1};
            // int[] pole = {};

            if (pole.Length < 1)
            {
                Console.WriteLine("Pole je prázdné.");
                return; //return v metodě Main ukončí vykonávání programu
            }

            double soucet = 0;
            double min = pole[0];
            double max = pole[0];


            for (int i = 0; i < pole.Length; i++)
            {
                int cislo = pole[i];

                if (cislo < min)
                    min = cislo;

                if (cislo > max)
                    max = cislo;

                soucet += cislo;
            }

            double prumer = soucet / pole.Length;

            Console.WriteLine();
            Console.WriteLine($"Minimum ze zadaných čísel bylo {min}, maximum {max} a průměr {prumer}.");
        }
    }
}
