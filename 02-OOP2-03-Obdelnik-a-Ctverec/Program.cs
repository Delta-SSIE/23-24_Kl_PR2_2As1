namespace _02_OOP2_03_Obdelnik_a_Ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obdelnik abcd = new Obdelnik(3, 7);
            Console.WriteLine(abcd.Popis());
            Console.WriteLine($"Obsah: {abcd.Obsah()}, obvod: {abcd.Obvod()}");
            Console.WriteLine(abcd);

            Console.WriteLine();

            Ctverec efgh = new Ctverec(5);
            Console.WriteLine(efgh.Popis());
            Console.WriteLine($"Obsah: {efgh.Obsah()}, obvod: {efgh.Obvod()}");


        }
    }
    class Obdelnik
    {
        public double StranaA { get; private set; }
        public double StranaB { get; private set; }

        public Obdelnik(double stranaA, double stranaB)
        {
            if (StranaA < 0)
                throw new ArgumentOutOfRangeException();
            StranaA = stranaA;

            if (StranaB < 0)
                throw new ArgumentOutOfRangeException();
            StranaB = stranaB;
        }

        public double Obvod()
        {
            return 2 * (StranaA + StranaB);
        }

        public double Obsah()
        {
            return StranaA * StranaB;
        }

        public virtual string Popis() //virtual - povolím, aby dědící třída mohla předělat
        {
            return $"Obdélník o stranách {StranaA} a {StranaB}";
        }

        public override string ToString()
        {
            return "Obdélník";
        }
    }
    class Ctverec : Obdelnik
    {
        public Ctverec(double strana) : base(strana, strana)
        {

        }

        public override string Popis() //override - předělávám rodičovskou metodu
        {
            return $"Čtverec o straně {StranaA}";
        }
    }
}
