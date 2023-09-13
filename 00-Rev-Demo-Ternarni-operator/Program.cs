namespace _00_Rev_Demo_Ternarni_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej celé číslo: ");
            int a = int.Parse(Console.ReadLine());

            //místo
            //if (a % 2 == 0)
            //    Console.WriteLine("číslo je sudé");
            //else
            //    Console.WriteLine("číslo je liché");

            //můžeme psát
            string vysledek = a % 2 == 0 ? "sudé" : "liché";
            Console.WriteLine($"Číslo je {vysledek}.");

        }
    }
}
