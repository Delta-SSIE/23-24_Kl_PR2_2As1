using System;

namespace _170_Naplneni_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který naplní pole uživatelem zadanými čísly. Velikost pole si určí sám uživatel prvním číslem.
            // Pak pole vypište.

            Console.Title = "Úloha 170 - Naplnění pole";


            Console.Write("Kolik prvků chceš do pole uložit: ");
            int pocetPrvku = int.Parse(Console.ReadLine());
            
            double[] pole = new double[pocetPrvku];


            // naplnění pole
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write($"Zadej prvek na pozici {i}: ");
                double cislo = double.Parse(Console.ReadLine());
                pole[i] = cislo;
            }


            // výpis pole
            Console.WriteLine(string.Join(", ", pole));
        }
    }
}
