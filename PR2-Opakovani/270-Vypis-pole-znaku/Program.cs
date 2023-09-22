using System;

namespace _270_Vypis_pole_znaku
{
    class Program
    {
        static void Main(string[] args)
        {
            // V již připravené části programu je na inicializováno dvojrozměrné pole:

            // Nyní se uživatele zeptejte na dva dotazy - zda chce vypsat řádek nebo sloupec, a pak který.
            // Na konci program vypíše řádek nebo sloupec dle přání uživatele.
            // Program by měl správně fungovat i pro různě velká pole znaků v inicializaci.

            // Vyzkoušejte s odkomentováním druhé možnosti deklarace pole, nezůstávejte jen u jedné - program musí být obecný   

            Console.Title = "Úloha 270 - Výpis pole znaků";

            char[,] znaky = new char[,]
            {
            { 'a', 'b', 'c', 'd', 'e', 'f' },
            { 'g', 'h', 'i', 'j', 'k', 'l' },
            { 'm', 'n', 'o', 'p', 'q', 'r' },
            { 't', 'u', 'v', 'w', 'x', 'y' }
            };

            // char[,] znaky = new char[,] 
            // {
            //     { 'a', 'b', 'c', 'd' },
            //     { 'e', 'f', 'g', 'h' },
            //     { 'i', 'j', 'k', 'l' }
            // };


            Console.WriteLine("Chceš vypsat řádek (r) nebo sloupec (s)?");
            string volba = Console.ReadLine().Trim().ToLower(); //oříznu případnou mezeru a převedu na malé písmeno            

            int pocetRadku = znaky.GetLength(0);
            int pocetSloupcu = znaky.GetLength(1);

            if (volba == "r")
            {
                Console.WriteLine($"Který řádek? (1 - {pocetRadku})");
                int radek = int.Parse(Console.ReadLine()) - 1; //sloupce čísluju od 1, ale PC od nuly, proto opravím
               
                if (radek >= 0 && radek < pocetRadku)
                {
                    for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
                    {
                        Console.Write(znaky[radek, sloupec]);
                    }
                }
                else
                {
                    Console.WriteLine("Neplatná volba, konec programu");
                    return;
                }
            }
            else if (volba == "s")
            {
                Console.WriteLine($"Který sloupec? (1 - {pocetSloupcu})");
                int sloupec = int.Parse(Console.ReadLine()) - 1;
                
                if (sloupec >= 0 && sloupec < pocetSloupcu)
                {
                    for (int radek = 0; radek < pocetRadku; radek++)
                    {
                        Console.Write(znaky[radek, sloupec]);

                    }
                }
                else
                {
                    Console.WriteLine("Neplatná volba, konec programu");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Neplatná volba, konec programu");
                return;
            }

        }
    }
}
