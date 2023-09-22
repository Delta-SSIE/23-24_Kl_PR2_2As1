using System;

namespace _100_Soucet
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus, který ze zadávaných čísel vypočítává součet. Uživatel ukončí zadávání čísel napsáním slova end.

			Console.Title = "Úloha 100 - Součet";
            Console.WriteLine("Zadávej čísla, já je budu sčítat. Pro ukončení vlož příkaz \"end\".");
            Console.WriteLine();


			double soucet = 0; //proměnná pro postupný součet

			while(true)
			{
				Console.Write("Zadej další číslo: ");
				string nacteno = Console.ReadLine(); //načtu vstup, ale nepřevádím

				if (nacteno.ToLower() == "end") //pokud je to "end" nebo "END", ukončím
					break;

				double cislo = double.Parse(nacteno); //převedu
				soucet += cislo; //přičtu
			}

			Console.WriteLine();
			Console.WriteLine($"Součet všech zadaných čísel je {soucet}.");
		}
    }
}
