using System;

namespace _130_Prubezna_statistika
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus, který uživateli na základě zadávaných čísel průběžně vypisuje, jestli je více lichých nebo sudých čísel.Zadávání uživatel ukončí napsáním slova end.

			Console.Title = "Úloha 130 - Průběžná statistika - sudé/liché";
			Console.WriteLine("Zadávej čísla, já budu dělat statistiku sudé vs. liché. Pro ukončení vlož příkaz \"end\".");
			Console.WriteLine();


			int pocetSudych = 0; 
			int pocetLichych = 0;


			while (true)
			{
				Console.Write("Zadej další číslo: ");
				string nacteno = Console.ReadLine(); //načtu vstup, ale nepřevádím

				if (nacteno.ToLower() == "end") //pokud je to "end" nebo "END", ukončím
					break;

				int cislo = int.Parse(nacteno); //převedu

				
				// připočítám jako sudé nebo liché
				if (cislo % 2 == 0)
					pocetSudych++;
				else
					pocetLichych++;


				//vypíšu statistiku
				if (pocetLichych < pocetSudych)
					Console.WriteLine("Sudých bylo zadáno více.");
				else if (pocetLichych == pocetSudych)
					Console.WriteLine("Sudých a lichých bylo zadáno stejně.");
				else
					Console.WriteLine("Lichých bylo zadáno více.");

                Console.WriteLine(); //jen prázdný řádek
			}
		}
    }
}
