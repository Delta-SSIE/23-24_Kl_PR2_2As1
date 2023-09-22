namespace _280_Nejvic_nul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cisla =
            {
                { 0,  0, 12, 0,  7},
                {13,  0,  5, 0,  1},
                { 0, -1,  0, 4,  5},
                { 1, -1,  0, 0, -5},
            };

            Console.WriteLine(NejvicNul(cisla)); //vypíše 3
            
            Console.WriteLine(NejvicNul2(cisla, true)); //vypíše 3
            Console.WriteLine(NejvicNul2(cisla, false)); //vypíše 3
        }

        private static int NejvicNul(int[,] cisla)
        {
            int maxPocetNul = 0;
            int maxIndex = 0;

            for (int x = 0; x < cisla.GetLength(1); x++)
            {
                int pocetNul = 0;
                for (int y = 0; y < cisla.GetLength(0); y++)
                {
                    if (cisla[y, x] == 0)
                        pocetNul++;
                }
                if (pocetNul > maxPocetNul)
                {
                    maxIndex = x;
                    maxPocetNul = pocetNul;
                }
            }

            return maxIndex;
        }


        private static int NejvicNul2(int[,] cisla, bool hledejSloupce)
        {
            int maxPocetNul = 0;
            int maxIndex = 0;

            int hledanyIndex, prochazenyIndex;
            if (hledejSloupce)
            {
                hledanyIndex = 1;
                prochazenyIndex = 0;
            }
            else
            {
                hledanyIndex = 0;
                prochazenyIndex = 1;
            }

            for (int x = 0; x < cisla.GetLength(hledanyIndex); x++)
            {
                int pocetNul = 0;
                for (int y = 0; y < cisla.GetLength(prochazenyIndex); y++)
                {
                    int cislo = hledejSloupce ? cisla[y, x] : cisla[x, y];
                    if (cislo == 0)
                        pocetNul++;
                }
                if (pocetNul > maxPocetNul)
                {
                    maxIndex = x;
                    maxPocetNul = pocetNul;
                }
            }

            return maxIndex;
        }

    }
}
