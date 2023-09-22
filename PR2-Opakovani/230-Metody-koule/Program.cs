using System;

namespace _230_Metody_koule
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte statické metody pro výpočet povrchu a objemu koule.

            Console.Title = "Úloha 230 - Metody pro výpočty na kouli";

            //využijeme metodu z předchozí úlohy

            double polomer = NactiDouble("Zadej poloměr koule: ");

            if (polomer > 0)
            {
                double povrch = PovrchKoule(polomer);
                double objem = ObjemKoule(polomer);

                Console.WriteLine($"Povrch koule o poloměru {polomer:0.00} je {povrch:0.00} a objem je {objem:0.00}.");
            }
            else
            {
                Console.WriteLine("Nesmyslná hodnota poloměru!");
            }

		}

		static double PovrchKoule(double polomer)
		{
			return 4 * Math.PI * polomer * polomer; //vzorce najdeme třeba v tabulkách 
		}

		static double ObjemKoule(double polomer)
		{
			return 4 / 3 * (Math.PI * polomer * polomer * polomer);
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
