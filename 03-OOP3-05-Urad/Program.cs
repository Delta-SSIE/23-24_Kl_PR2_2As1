namespace _03_OOP3_05_Urad
{
    class Program
    {
        public static void Main(string[] args)
        {

            int pocetPrepazek = 50;

            Clovek[] lide =
            {
                new Clovek("Josef", "Smutný", 4),
                new Clovek("Anna", "Veselá", 3),
                new Clovek("Marie", "Zelená", 12),
                new Clovek("Jiří", "Červenka", 3),
                new Clovek("Antonín", "Černý", 5),
                new Clovek("Antonie", "Bohatá", 7),
                new Clovek("Richard", "Těsný", 4),
                new Clovek("Luisa", "Podhorská", 15),
            };

            //vytvořit přepážky
            Prepazka[] prepazky = new Prepazka[pocetPrepazek];
            for (int i = 0; i < pocetPrepazek; i++)
            {
                prepazky[i] = new Prepazka(i + 1);
            }

            //vytvořit frontu lidí
            Queue<Clovek> fronta = new Queue<Clovek>(lide);

            //zapnout hodiny
            int cas = 0;

            //dokud ve frontě někdo je
            while (fronta.Count > 0) 
            {
                //zkontrolovat, jestli je nějaká přepážka volná (a poslat ho tam)
                foreach (Prepazka prepazka in prepazky)
                {
                    if (prepazka.KdyBudeVolno <= cas)
                    {
                        if (fronta.Count == 0) break; //lidi došli, přepážky ještě ne

                        Clovek zakaznik = fronta.Dequeue();
                        prepazka.OdbavCloveka(zakaznik, cas);
                    }
                }
                //posunout hodiny
                cas++;
            }
        }
    }

    class Clovek
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Trvani { get; private set; }

        public Clovek(string jmeno, string prijmeni, int trvani)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Trvani = trvani;
        }
    }

    class Prepazka
    {
        public int Cislo { get; private set; }
        public int KdyBudeVolno { get; private set; }

        public Prepazka(int cislo)
        {
            Cislo = cislo;
            KdyBudeVolno = 0;
        }

        public void OdbavCloveka(Clovek clovek, int cas)
        {
            KdyBudeVolno = cas + clovek.Trvani;
            Console.WriteLine($"Přepážka {Cislo}, {clovek.Jmeno} {clovek.Prijmeni} : {cas} - {KdyBudeVolno}");
        }
    }
}
