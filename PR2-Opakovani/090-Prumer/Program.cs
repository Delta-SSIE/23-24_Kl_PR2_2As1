using System;

namespace _090_Prumer
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus, který vypočítá aritmetický průměr ze zadaných čísel.
			// Počet zadávaných čísel si uživatel nejprve zvolí, pak čísla postupně zadá.

			Console.Title = "Úloha 090 - Průměr";
			
			Console.Write("Zadej počet čísel: ");
			int pocet = int.Parse(Console.ReadLine());
			
			double soucet = 0;
			for (int i = 1; i <= pocet; i++)
			{
				Console.Write($"Zadej {i}. číslo: ");
				double cislo = double.Parse(Console.ReadLine());
				soucet += cislo;
			}

			double prumer = soucet / pocet;

            Console.WriteLine();
			Console.WriteLine($"Průměr zadaných čísel je {prumer:0.00}."); //zaokrouhleno na 2 desetinná
		}
    }
}
