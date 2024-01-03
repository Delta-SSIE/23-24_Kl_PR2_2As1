namespace _03_OOP2_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 10;
            if (cislo.IsEven())
            {
                Console.WriteLine($"Číslo {cislo} je sudé");
            }
            else
            {
                Console.WriteLine($"Číslo {cislo} je liché");
            }
            Console.WriteLine(cislo.NegativeValue());

            Console.WriteLine(cislo.IsInsideInterval(15,20));
            Console.WriteLine(cislo.IsInsideInterval(1,20));

        }
    }

    static class Utils
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
        public static int NegativeValue(this int i)
        {
            return -i;
        }
        public static bool IsInsideInterval(this int i, int lowerThreshold, int upperThreshold)
        {
            return i >= lowerThreshold && i <= upperThreshold;
        }

    }
}
