using System;

namespace _180_Analyza_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který projde pole a zjistí, kolik čísel je kladných, záporných nebo nulových.

            Console.Title = "Úloha 180 - Analýza pole";

            // vyzkoušejte s jiným polem pomocí zakomentování/odkomentování řádku
            int[] pole = { -5, 3, 2, -3, 7, 0, 12, -1 };
            // int[] pole = {1, 3, 2, 1, 7, 0, 12, -1};
            // int[] pole = {-1};
            // int[] pole = {};


            int pocetZapornych = 0;
            int pocetNul = 0;
            int pocetKladnych = 0;

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < 0)
                    pocetZapornych++;
                else if (pole[i] == 0)
                    pocetNul++;
                else
                    pocetKladnych++;
            }

            Console.WriteLine($"V poli je {pocetZapornych} záporných čísel, {pocetKladnych} kladných čísel a {pocetNul} nul.");

        }
    }
}
