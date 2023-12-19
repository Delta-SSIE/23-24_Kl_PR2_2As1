namespace _02_OOP2_05_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Character mcLovin = new Character("McLovin", 250, 100);

            //Item[] things = {
            //    new Item("stone", 240),
            //    new Item("flask", 40),
            //    new Item("ring", 2),
            //};

            //Console.WriteLine($"{mcLovin.Name} is carrying: ");
            //Console.WriteLine(mcLovin.GetItemList());
            //Console.WriteLine();

            //foreach (Item item in things)
            //{
            //    bool success = mcLovin.Take(item);
            //    if (success)
            //    {
            //        Console.WriteLine($"{mcLovin.Name} has taken {item.Name}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{mcLovin.Name} cannot carry {item.Name}, inventory full.");
            //    }
            //    Console.WriteLine($"{mcLovin.Name} is carrying: ");
            //    Console.WriteLine(mcLovin.GetItemList());
            //    Console.WriteLine();

            Character will = new Character("William", 250, 50);

            Armor leatherArmor = new Armor("Leather armor", 50, 3);
            will.Take(leatherArmor);
            will.Equip(leatherArmor);

            Weapon sword = new Weapon("Sword", 20, 7);
            will.Take(sword);
            will.Equip(sword);

            Shield shield = new Shield("Shield", 30, 1);
            will.Take(shield);
            will.Equip(shield);


            Character bob = new Character("Robert", 240, 45);
            
            Armor chainMail = new Armor("Chain mail", 120, 6);
            bob.Take(chainMail);
            bob.Equip(chainMail);

            Weapon mace = new Weapon("mace", 5, 5);
            bob.Take(mace);
            bob.Equip(mace);

            //ConsoleLogger logger = new ConsoleLogger();
            FileLogger logger = new FileLogger("combat.txt");
            Combat combat = new Combat(will, bob, logger);
            combat.Fight();
        }
    }    
}
