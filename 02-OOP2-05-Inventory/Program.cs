namespace _02_OOP2_05_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character mcLovin = new Character("McLovin", 250, 100);

            Item[] things = {
                new Item("stone", 240),
                new Item("flask", 40),
                new Item("ring", 2),
            };

            Console.WriteLine($"{mcLovin.Name} is carrying: ");
            Console.WriteLine(mcLovin.GetItemList());
            Console.WriteLine();

            foreach (Item item in things)
            {
                bool success = mcLovin.Take(item);
                if (success)
                {
                    Console.WriteLine($"{mcLovin.Name} has taken {item.Name}.");
                }
                else
                {
                    Console.WriteLine($"{mcLovin.Name} cannot carry {item.Name}, inventory full.");
                }
                Console.WriteLine($"{mcLovin.Name} is carrying: ");
                Console.WriteLine(mcLovin.GetItemList());
                Console.WriteLine();
            }
        }
    }
}
