namespace _01_OOP_21_Pes_a_clovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek franta = new Clovek("František", "Novotný");
            Pes baryk = new Pes("Baryk");
            Console.WriteLine(baryk.Jmeno);

            if (baryk.Pan != null)
                Console.WriteLine($"{baryk.Jmeno} má pána jménem {baryk.Pan.Jmeno} {baryk.Pan.Prijmeni}.");
            else
                Console.WriteLine($"{baryk.Jmeno} nemá pána.");

            baryk.Pan = franta;

            if (baryk.Pan != null)
                Console.WriteLine($"{baryk.Jmeno} má pána jménem {baryk.Pan.Jmeno} {baryk.Pan.Prijmeni}.");
            else
                Console.WriteLine($"{baryk.Jmeno} nemá pána.");

        }
    }
}
