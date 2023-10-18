namespace _01_OOP_060_Paginator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paginator p = new Paginator(new string[] { "Přemysl", "Nezamysl", "Mnata", "Vojen", "Vnislav", "Křesomysl", "Neklan", "Hostivít" }, 3);

            Console.WriteLine(p.ItemCount); //vypíše 8
            Console.WriteLine(p.PageCount); //vypíše 3

            Console.WriteLine();
            Console.WriteLine(p.GetPageItemCount(1)); //vypíše 3
            Console.WriteLine(p.GetPageItemCount(2)); //vypíše 2
            Console.WriteLine(p.GetPageItemCount(5)); //vypíše 0

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", p.GetPage(1))); //vypíše "Vojen", "Vnislav", "Křesomysl"
            Console.WriteLine(string.Join(", ", p.GetPage(2))); //vypíše "Neklan", "Hostivít"
            Console.WriteLine(string.Join(", ", p.GetPage(5))); //vypíše prázdno

            Console.WriteLine();
            Console.WriteLine(p.FindPage("Vnislav")); //vypíše 1
            Console.WriteLine(p.FindPage("Miloš")); //vypíše -1
        }
    }
}
