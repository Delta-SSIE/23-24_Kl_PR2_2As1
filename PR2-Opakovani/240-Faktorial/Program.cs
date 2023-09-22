using System;

namespace _240_Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sestavte metodu, která vypíše faktoriál předaného čísla.
            // Faktoriál značíme !
            // 0! = 1;
            // pro větší čísla je faktorál součin všech menších čísel, tedy 5! = 5 * 4 * 3 * 2 * 1

            Console.Title = "Úloha 240 - Faktoriál";

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial2(5));
        }

        static ulong Factorial(ulong n)
        {
            ulong fact = 1;
            for (ulong i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact; 
        }

        //nebo úplně jinak, protože 5! = 5 * 4! (= 5 * 4 * 3 * 2 * 1)
        static ulong Factorial2 (ulong n)
        {
            if (n == 0)
                return 1;

            return n * Factorial2(n - 1);
        }
    }
}
