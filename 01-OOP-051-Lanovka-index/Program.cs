namespace _01_OOP_051_Lanovka_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lanovka l = new Lanovka(3, 250);

            Clovek jara = new Clovek("Jaroslav", 80);
            Clovek pepa = new Clovek("Josef", 130);
            Clovek marta = new Clovek("Marta", 45);


            Console.WriteLine(l.Nastup(jara));
            Console.WriteLine(l.Nastup(pepa));
            l.Vypis();
            l.Jed();
            l.Vypis();

            Console.WriteLine(l.Nastup(pepa));
            l.Jed();
            l.Vypis();

            Console.WriteLine(l.Nastup(marta));

            Clovek vystoupil;

            vystoupil =  l.Vystup();
            Console.WriteLine(vystoupil.Jmeno);

            Console.WriteLine(l.Nastup(marta));
            l.Vypis();

            l.Jed();
            vystoupil = l.Vystup();
            Console.WriteLine(vystoupil.Jmeno);

            //l.Jed();
        }
    }
}
