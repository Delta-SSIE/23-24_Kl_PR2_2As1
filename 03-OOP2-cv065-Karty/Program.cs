namespace _03_OOP2_cv_065_Karty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Karta[] karty = {
                new Karta(Vyska.Svrsek, Barva.Zaludy),
                new Karta(Vyska.Eso, Barva.Srdce),
                new Karta(Vyska.Svrsek, Barva.Zelene),
                new Karta(Vyska.Sedma, Barva.Kule),
                new Karta(Vyska.Desitka, Barva.Zaludy),
            };
            Array.Sort(karty); //díky IComparable mohu třídit

            foreach (Karta karta in karty)
            {
                Console.WriteLine(karta);
            }


            Console.WriteLine();

            Karta moje = new Karta(Vyska.Svrsek, Barva.Zaludy);
            Karta tvoje = new Karta(Vyska.Eso, Barva.Kule);

            if (moje > tvoje)
            {
                Console.WriteLine($"Mám větší kartu ({moje} > {tvoje})");
            }
            else if (moje < tvoje)
            {
                Console.WriteLine($"Mám menší kartu ({moje} < {tvoje})");
            }
            else
            {
                Console.WriteLine($"Máme stejně vysoké karty ({moje} a {tvoje})");
            }

        }
    }
}
