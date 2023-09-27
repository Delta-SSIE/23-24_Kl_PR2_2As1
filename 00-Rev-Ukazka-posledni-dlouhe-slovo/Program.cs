
namespace _00_Rev_Ukazka_posledni_dlouhe_slovo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] slova = { "Karel", "Eva", "Jaromír", "Iva", "Martin" };
            Console.WriteLine(PosledniDlouhe(slova, 5)); //vypíše "Martin"
            Console.WriteLine(PosledniDlouhe(slova, 7)); //vypíše "Jaromír"
            Console.WriteLine(PosledniDlouhe(slova, 12)); //vypíše prázdno
        }

        static string PosledniDlouhe(string[] slova, int limit)
        {
            for (int i = slova.Length - 1; i >= 0; i--)
            {
                string slovo = slova[i];
                if (slovo.Length == limit)
                    return slovo;
            }

            return "";
        }
    }
}
