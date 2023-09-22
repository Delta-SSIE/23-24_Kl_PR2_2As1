using System;

namespace _160_Je_prvocislo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte program, který určí, zda uživatelem zadané číslo je nebo není prvočíslo.

            Console.Title = "Úloha 160 - Je prvočíslo?";
            Console.WriteLine("Zadej číslo, já řeknu, zda je to prvočíslo, nebo číslo složené.");

            Console.Write("Vlož číslo: ");
            double cislo = double.Parse(Console.ReadLine());

            int hranice = (int) Math.Floor(Math.Sqrt(cislo)); //nemá cenu testovat dělitelnost číslem větším, než je odmocnina

            bool jePrvocislo = true;
            for (int i = 2; i <= hranice; i++)
            {
                if (cislo % i == 0)
                { 
                    jePrvocislo = false;
                    break; //už vím, že to není prvočíslo, končím s procházením, dál nemá cenu
                }
            }

            if (jePrvocislo) //prošel jsem všechny podezřelé dělitele a nenašel, proto zbylo prvočíslo
                Console.WriteLine($"Číslo {cislo} je prvočíslo.");
            else
                Console.WriteLine($"Číslo {cislo} je složené.");
        }
    }
}
