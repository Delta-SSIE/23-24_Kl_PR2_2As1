namespace _01_OOP_020_Tachometr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvořte nový tachometr
            Tachometr t = new();
            Console.WriteLine($"Celkem bylo najeto {t.Stav} km.");

            //zkuste jeho stav několikrát zvýšit a pak vypsat

            while (true)
            {
                Console.Write("Kolik jsi najel: ");
                string vstup = Console.ReadLine();

                if (vstup.ToLower() == "stop")
                    break;

                try
                {
                    int vzdalenost = int.Parse(vstup);
                    t.Ujed(vzdalenost);
                    Console.WriteLine($"Celkem bylo najeto {t.Stav} km.");

                }
                catch
                {
                    Console.WriteLine("Nezdařilo se ujet vzdálenost. Dává smysl?");
                }

            }

        }
    }
}
