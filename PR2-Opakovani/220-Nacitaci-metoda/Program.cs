using System;

namespace _220_Nacitaci_metoda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte statickou metodu, která načte od uživatele desetinné číslo a vrátí jej.
            // Pokud uživatel zadá neplatný vstup, vyzve ho metoda k opakování(tak dlouho dokud nebude vstup platný)

            Console.Title = "Úloha 220 - Načítací metoda";

            double nacteno = NactiDouble("Zadej desetinné číslo: ");
            
            Console.WriteLine();
            Console.WriteLine($"Zadal jsi {nacteno}.");

        }

        static double NactiDouble(string vyzva = "Zadej číslo: ", string varovani = "Neplatný vstup!")
        {
            Console.Write(vyzva);

            double cislo;
            string vstup = Console.ReadLine();

            while (!double.TryParse(vstup, out cislo)) //dokud se nepodaří převod, bude to zkoušet znovu
            {
                Console.WriteLine(varovani);
                Console.WriteLine();
                Console.Write(vyzva);
                vstup = Console.ReadLine();
            }

            return cislo;

        }
    }
}
