using System;

namespace _010_Promenne
{
    class Program
    {
        static void Main(string[] args)
        {
			//Deklarujte a inicializujte proměnnou x na hodnotu 10 a y na 20.
			//Pak prohoďte jejich hodnoty a vypište je.

			Console.Title = "Úloha 01 - Proměnné";
			int x = 10;
			int y = 20;

			Console.WriteLine($"Proměnná X obsahuje {x}.");
			Console.WriteLine($"Proměnná Y obsahuje {y}.");
			
			//záměna
			int z = x;
			x = y;
			y = z;

            Console.WriteLine();
			Console.WriteLine($"Proměnná X nyní obsahuje {x}.");
			Console.WriteLine($"Proměnná Y nyní obsahuje {y}.");
		}
    }
}
