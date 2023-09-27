namespace _00_Rev_Exceptions_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            try 
            { 
                Console.WriteLine(5/i);
            }
            catch 
            {
                Console.WriteLine("To se nějak nepovedlo. Dělíš nulou");
            };

            double podil = 5.0 / 0;
            Console.WriteLine(podil);
        }
    }
}
