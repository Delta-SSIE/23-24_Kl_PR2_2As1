using System;

namespace _140_Pocet_delitelnych
{
    class Program
    {
        static void Main(string[] args)
        {
			// Sestavte algoritmus, který zjistí, kolikrát se mezi zadávanými čísly vyskytlo číslo dělitelné 3 nebo 4. Zadávání uživatel ukončí napsáním slova end.

			Console.Title = "Úloha 140 - Počet dělitelných";
			Console.WriteLine("Zadávej čísla, já zjistím, kolikrát se vyskytlo číslo dělitelné 3 nebo čtyřmi. Pro ukončení vlož příkaz \"end\".");
			Console.WriteLine();

			int pocet = 0;


			while (true)
			{
				Console.Write("Zadej další číslo: ");
				string nacteno = Console.ReadLine(); //načtu vstup, ale nepřevádím

				if (nacteno.ToLower() == "end") //pokud je to "end" nebo "END", ukončím
					break;

				int cislo = int.Parse(nacteno); //převedu


				// připočítám, pokud splňuje podmínky
				if (cislo % 3 == 0 || cislo % 4 == 0)
					pocet++;


				//vypíšu statistiku
				Console.WriteLine($"Bylo vloženo {pocet} čísel splňujících podmínky.");
				Console.WriteLine(); //jen prázdný řádek
			}
		}
    }
}
