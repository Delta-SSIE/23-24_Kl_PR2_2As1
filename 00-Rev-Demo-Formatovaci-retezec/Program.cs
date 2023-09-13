namespace _00_Rev_Demo_Formatovaci_retezec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 3.14159;
            double e = 2.71828;

            //jako interpolace řetězců
            Console.WriteLine($"Zaokrouhleno: i = {i:0.000} , e = {e:0.000}");
            Console.WriteLine($"Doplněno zleva nulami a mezerou: i = {i:0 000.0}, e = {e:0 000.0}");

            //jako formatting sting
            Console.WriteLine("Zaokrouhleno: i = {0:0.000} , e = {1:0.000}", i, e);
            Console.WriteLine("Doplněno zleva nulami a mezerou: i = {0:0 000.0}, e = {1:0 000.0}", i, e);

        }
    }
}
