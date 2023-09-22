using System;

namespace _150_Je_trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte algoritmus, který určí, zda je možné ze tří uživatelem zadaných čísel vytvořit trojúhelník.

            Console.Title = "Úloha 140 - Lze sestavit trojúhelník?";
            Console.WriteLine("Zadej tři čísla (délky stran), já zjistím, zda takový trojúhelník lze sestavit.");

            
            Console.Write("Zadej 1. stranu: ");
            double strana1 = double.Parse(Console.ReadLine());

            Console.Write("Zadej 2. stranu: ");
            double strana2 = double.Parse(Console.ReadLine());

            Console.Write("Zadej 3. stranu: ");
            double strana3 = double.Parse(Console.ReadLine());


            string stav;
            if ( 
                strana1 > 0 && strana2 > 0 && strana3 > 0
                && strana1 + strana2 > strana3
                && strana2 + strana3 > strana1
                && strana3 + strana1 > strana2
            )
            {
                stav = "lze";    
            }
            else
            {
                stav = "nelze";
            }

            Console.WriteLine($"Trojúhelník o stranách ({strana1}; {strana2}; {strana3}) {stav} sestavit.");
        }
    }
}
