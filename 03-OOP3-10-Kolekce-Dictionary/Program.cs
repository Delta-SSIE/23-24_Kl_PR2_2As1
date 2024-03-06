namespace _03_OOP3_10_Kolekce_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> vklady = new Dictionary<string, int>();

            vklady["Franta"] = 50;
            vklady["Lojza"] = 80;

            vklady["Lojza"] -= 40;

            foreach (var item in vklady)
            {
                Console.WriteLine($"{item.Key} na kontě má {item.Value}");
            }

            Console.WriteLine(vklady["Lojza"]);
            Console.WriteLine(vklady["Vojta"]);
            //vklady.
        }
    }
}
