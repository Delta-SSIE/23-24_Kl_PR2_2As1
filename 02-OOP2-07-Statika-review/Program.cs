namespace _02_OOP2_07_Statika_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek.Popis();

            Console.WriteLine($"Na světě je {Clovek.PocetLidi} lidí");
            Clovek franta = new Clovek("František");
            Console.WriteLine($"Na světě je {Clovek.PocetLidi} lidí");
            Clovek lojza = new Clovek("Alois");
            Console.WriteLine($"Na světě je {Clovek.PocetLidi} lidí");

            //Math m = new Math();

        }
    }

    class Clovek { 
        public string Jmeno { get; set; }
        public static int PocetLidi { get; private set; } = 0; 
        public static void Popis() 
        { 
            Console.WriteLine("Lidé jsou humaniodní rasa, ne nepodobná gorilám, vyznačují se ale nižší \n"
                + "inteligencí, fyzickou silou i celkovou odolností.Nejsou také schopni \n"
                +"artikulované řeči.");
            //Console.WriteLine(Jmeno); //nelze - Jmeno není statické, proto k němu statická metoda nemá přístup
        }

        public Clovek(string jmeno)
        {
            Jmeno = jmeno;
            PocetLidi++;
        }
    }

}
