using System;

namespace _030_Obdelnik
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus na výpočet obvodu a obsahu obdélníka. Uživatel zadá dvě strany a vypíší se mu výsledky.
			Console.Title = "Úloha 030 - Obdélník";
						
			double stranaA, stranaB;
			string vstup;


			Console.Write("Zadej jednu stranu obdélníka: ");
			vstup = Console.ReadLine();

			//když se nepovede převod, nebo strana není kladná, zkusíme zadávání znovu
			while (!double.TryParse(vstup, out stranaA) || stranaA <= 0) 
            {
                Console.Write("Neplatný vstup, zadej stranu znovu: ");
				vstup = Console.ReadLine();
            }


			Console.Write("Zadej druhou stranu obdélníka: ");
			vstup = Console.ReadLine();

			while (!double.TryParse(vstup, out stranaB) || stranaB <= 0)
			{
				Console.Write("Neplatný vstup, zadej stranu znovu: ");
				vstup = Console.ReadLine();
			}


			double obvod = 2 * (stranaA + stranaB);
			double obsah = stranaA * stranaB;


			Console.WriteLine();
			Console.WriteLine($"Obvod je {obvod}.");
			Console.WriteLine($"Obsah je {obsah}.");
		}
    }
}
