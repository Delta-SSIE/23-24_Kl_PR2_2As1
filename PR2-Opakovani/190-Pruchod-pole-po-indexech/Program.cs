using System;

namespace _190_Pruchod_pole_po_indexech
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sestavte algoritmus, který určí součet prvků na sudých indexech pole a součin na lichých.

            Console.Title = "Úloha 190 - Průchod pole po indexech";

            //int[] pole = { -5, 3, 2, -3, 7, 0, 12, -1 };
            int[] pole = { 1, 3, 2, 1, 7, 1, 12, -1 };
            // int[] pole = {-1};
            // int[] pole = {};


            int soucet = 0;
            for (int i = 0; i < pole.Length; i+=2) //sudé indexy, začnu na 0, stoupám po dvou
            {
                soucet += pole[i];
            }


            int soucin = 1;
            for (int i = 1; i < pole.Length; i+=2) //tentokrát začnu na lichých
            {
                soucin *= pole[i];
            }


            if (pole.Length > 0)
                Console.WriteLine($"Součet prvků na sudých indexech je {soucet}.");
            else
                Console.WriteLine("Pro vyhodnocení součtu je pole příliš krátké");


            if (pole.Length > 1)
                Console.WriteLine($"Součin prvků na lichých indexech je {soucin}.");
            else
                Console.WriteLine("Pro vyhodnocení součinu je pole příliš krátké");

        }
    }
}
