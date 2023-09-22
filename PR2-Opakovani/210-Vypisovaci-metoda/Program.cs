using System;

namespace _210_Vypisovaci_metoda
{
    class Program
    {
        static void Main(string[] args)
        {
            // 210-Vypisovaci-metoda

            Console.Title = "Úloha 210 - Vypisovací metoda";

            Print("Nazdar!");
            Print("Ahoj!");
        }

        static void Print(string text)
        {
            Console.WriteLine(text); 
            //nedelá nic jiného, než že převezme parametr a vypíše do konzole
            // je tu jen proto, abychom si vzpomněli, jaká je syntaxe při psaní metody
        }
    }
}
