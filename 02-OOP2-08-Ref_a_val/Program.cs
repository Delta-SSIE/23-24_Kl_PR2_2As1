namespace _02_OOP2_08_Ref_a_val
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a;
            b--;
            Console.WriteLine(a);


            Cislo c = new Cislo(10);
            Cislo d = c;
            d.Hodnota = 20;
            Console.WriteLine(c.Hodnota);
            Zmensi(c);
            Console.WriteLine(c.Hodnota);

            string text = "ASDFG";
            Prodluz(text);
            Console.WriteLine(text);
        }

        static void Zmensi (Cislo cislo)
        {
            cislo.Hodnota--;
        }

        static void Prodluz(string s)
        {
            s += 'A';
        }
    }

    class Cislo
    {
        public int Hodnota;

        public Cislo(int hodnota)
        {
            Hodnota = hodnota;
        }
    }
}
