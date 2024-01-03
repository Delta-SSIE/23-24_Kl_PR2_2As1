using System.Diagnostics;

namespace _02_OOP2_09_Prodlouzeni_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 1000000;
            string s = "";

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < pocet; i++)
            {
                s += 'A';
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
    }
}
