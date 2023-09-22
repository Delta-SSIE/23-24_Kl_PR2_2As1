using System;
using System.Linq;

namespace _250_Vsechna_mensi_nez
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte metodu s názvem JsouVsechnaMensiNez, která bude dostávat 2 parametry - desetinné číslo Hodnota a pole desetinných čísel Cisla.
            // Metoda bude vracet logickou hodnotu, zda jsou všechna čísla v poli Cisla menší než předaná Hodnota nebo nejsou.

            // Hlavní program je hotový, napište jen metodu JsouVsechnaMensiNez

            Console.Title = "Úloha 250 - Všecha menší než";

            double[] cisla = { 1, 4, 15, 2, 7, 6, 10, 4 };

            //double hodnota = 16;
            double hodnota = 12;


            if (JsouVsechnaMensiNez(hodnota, cisla))
                Console.WriteLine($"Všechny hodnoty v poli jsou menší než {hodnota}.");
            else
                Console.WriteLine($"V poli jsou i hodnoty větší nebo rovné {hodnota}.");


            //využití alternativní metody
            if (JsouVsechnaMensiNezLinq(hodnota, cisla))
                Console.WriteLine($"Všechny hodnoty v poli jsou menší než {hodnota}.");
            else
                Console.WriteLine($"V poli jsou i hodnoty větší nebo rovné {hodnota}.");
        }

        static bool JsouVsechnaMensiNez(double hodnota, double[] cisla)
        {
            foreach (double cislo in cisla)
            {
                if (cislo >= hodnota)
                    return false; //jakmile najdu nějaké číslo nesplňující podmínku, vracím false
            }

            return true; //pokud jsem došel až sem, splňovala všechna
        }

        // Jen tak jako ukázka, že to jde i jinak. Tohle jsme se neučili
        static bool JsouVsechnaMensiNezLinq(double hodnota, double[] cisla) => cisla.All(x => x < hodnota);

    }
}
