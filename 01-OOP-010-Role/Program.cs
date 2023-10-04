namespace _01_OOP_010_Role
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                Role role = new Role("červená", -50);
                Console.WriteLine(role);
            }
            catch
            {
                Console.WriteLine("Chyba při tvorbě role");
            }

            try
            {
                Role role = new Role("modrá", 250);
                Console.WriteLine(role);
                role.Delka = -80;
                Console.WriteLine(role);
                
            }
            catch
            {
                Console.WriteLine("Chyba při práci s rolí");
            }

            Role r = new Role();
            
        }
    }
}
