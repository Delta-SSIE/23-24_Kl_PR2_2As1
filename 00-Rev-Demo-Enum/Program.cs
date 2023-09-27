
namespace _00_Rev_Demo_Enum
{
    enum Obdobi { Jaro, Leto, Podzim, Zima };

    internal class Program
    {
        static void Main(string[] args)
        {
            //Obdobi sezona = Obdobi.Jaro;
            //Obdobi jindy = Obdobi.Leto;

            //if (sezona == Obdobi.Podzim)
            //    ;//něco dělej;

            //Console.WriteLine(sezona);


            //Obdobi chladne = Obdobi.Jaro;
            //Console.WriteLine(chladne);
            //chladne++;
            //Console.WriteLine(chladne);

            //Console.ReadKey();


            Obdobi sezona = Obdobi.Podzim;
            sezona++;
            Console.WriteLine(sezona);
            sezona++;
            Console.WriteLine(sezona);

            Console.ReadKey();

        }
    }
}
