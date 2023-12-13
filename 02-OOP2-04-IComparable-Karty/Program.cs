namespace _02_OOP2_04_IComparable_Karty
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


            Karta eso = new Karta(Vyska.Eso, Barva.Srdce);
            Karta filek = new Karta(Vyska.Svrsek, Barva.Srdce);

            if (eso > filek)
            {
                Console.WriteLine($"{eso} je větší než {filek}");
            }
            else if (eso < filek)
            {
                Console.WriteLine($"{eso} je menší než {filek}");
            }
            else
            {
                Console.WriteLine($"{eso} a {filek} jsou stejně vysoké");
            }
        }
    }
}
