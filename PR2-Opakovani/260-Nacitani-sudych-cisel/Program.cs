using System;

namespace _260_Nacitani_sudych_cisel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napište program, který
            // se na začátku zeptá na kladné číslo n
            // vytvoří pole pro n celých čísel
            // bude od uživatele načítat čísla
            // a pokud jsou sudá, bude je ukládat do pole, dokud nebude plné (program nespadne, pokud uživatel zadá nesmysl)
            // lichá přeskočí
            // pak vypíše uložená čísla v opačném pořadí

            Console.Write("Kolik čísel mám uložit: ");

            int pocet;
            string vstup = Console.ReadLine();

            while (!int.TryParse(vstup, out pocet)) //dokud se nepodaří převod, bude to zkoušet znovu
            {
                Console.WriteLine("Neplatný vstup");
                Console.WriteLine();
                Console.Write("Kolik čísel mám uložit: ");
                vstup = Console.ReadLine();
            }


            int[] sude = new int[pocet]; //vytvořím pole pro sudá čísla
            int i = 0; //ukazuje pozici, na kterou se uloží příští sudé číslo

            while (i < pocet) //dokud není plno
            {
                Console.Write("Zadej další číslo: ");
                vstup = Console.ReadLine(); //načtu vstup

                if (int.TryParse(vstup, out int cislo) && cislo % 2 == 0) //když se povede převod a číslo je sudé
                {
                    sude[i] = cislo; //uložím ho
                    i++; //zvýším si počítadlo
                }
            }

            Console.WriteLine();
            Console.WriteLine("Konec zadávání, vypíšu odzadu");
            Console.WriteLine();

            for (int j = pocet - 1; j >= 0; j--)
            {
                Console.Write(sude[j] + " ");
            }
        }
    }
}
