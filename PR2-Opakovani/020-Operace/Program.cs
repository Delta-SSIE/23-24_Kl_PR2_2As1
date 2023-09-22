using System;

namespace _020_Operace
{
    class Program
    {
        static void Main(string[] args)
        {
			// Deklarujte a inicializujte proměnnou x na hodnotu 10 a y na 20.
			// Pak deklarujte proměnné sum, difference, product a quotient a inicializujte je výsledky daného typu výpočtu.
			// Nakonec hodnoty proměnných vypište.

			Console.Title = "Úloha 020 - Operace";

			int x = 10;
			int y = 20;

			int sum = x + y;
			int difference = x - y;
			int product = x * y;
			double quotient = (double)x / y; // V případě dvou celočíselných datových typů dochází k celočíslenému dělení, proto je nutné alespoň jedno z čísel převést na desetinné

			Console.WriteLine($"{x} + {y} = {sum}");
			Console.WriteLine($"{x} - {y} = {difference}");
			Console.WriteLine($"{x} * {y} = {product}");
			Console.WriteLine($"{x} / {y} = {quotient}");
		}
    }
}
