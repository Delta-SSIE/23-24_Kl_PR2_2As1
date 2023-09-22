using System;

namespace _040_Kruh
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus na výpočet obvodu a obsahu kruhu. Uživatel zadá jeho poloměr a vypíšou se mu výsledky.

			// Nezapomeňte, že uživatel může zadat i neplatné hodnoty.Pokud jejich ošetření nezvládnete nyní, k úloze se vraťte.

			Console.Title = "Úloha 040 - Kruh";


			//načítání

			double polomer;
			string vstup;

			Console.Write("Zadej jednu poloměr kruhu: ");
			vstup = Console.ReadLine();

			//když se nepovede převod, nebo poloměr není kladný, zkusíme zadávání znovu
			while (!double.TryParse(vstup, out polomer) || polomer <= 0)
			{
				Console.Write("Neplatný vstup, zadej poloměr znovu: ");
				vstup = Console.ReadLine();
			}

			// výpočty
			double obvod = 2 * Math.PI * polomer;
			double obsah = Math.PI * polomer * polomer;

			//výpisy
			Console.WriteLine();
			Console.WriteLine($"Obvod je {obvod:0.000}."); //zaformátuju výstup na 3 desetinná
			Console.WriteLine($"Obsah je {obsah:0.000}.");
		}
    }
}
