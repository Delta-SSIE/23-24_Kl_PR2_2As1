namespace _02_OOP2_Cv06_Utvary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ctverec ctverec = new Ctverec(5);
            Ctverec ctverec2 = new Ctverec(4);
            Kruh kolecko = new Kruh(1);

            IUtvar[] utvary = { ctverec, ctverec2, kolecko };

            foreach (IUtvar utvar in utvary)
            {
                Console.WriteLine(utvar.ToString());
            }
            Console.WriteLine();

            PlechovkaBarvy plechovka = new(80, 2);
            foreach (IUtvar utvar in utvary)
            {
                Console.WriteLine(plechovka);
                Console.WriteLine(plechovka.Obarvi(utvar));
            }
            Console.WriteLine(plechovka);



        }
    }
}
