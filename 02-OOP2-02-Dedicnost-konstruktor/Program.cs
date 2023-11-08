namespace _02_OOP2_02_Dedicnost_konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kun kobylka = new Kun("Ferda");
            //kobylka.Cvalej();
            //kobylka.Dychej();
            //kobylka.NapijSe();
            ////kobylka.Plav(); //nelze

            //Velryba mobyDick = new Velryba("Moby Dick");
            //mobyDick.Dychej();
            //mobyDick.NapijSe();
            //mobyDick.Plav();

            //Savec konik = new Kun("Trop");
            //konik.Dychej();
            //Console.WriteLine($"Tohle je {konik.Jmeno}");
            ////konik.Cvalej(); //nelze, vidím jen metody savce kvůli typu proměnné konik

            //Kun konik2 = (Kun)konik; //type casting ... vnutím mu typ
            //konik2.Cvalej();
            //konik2.PridejKeJmenu(", vítěz");
            //Console.WriteLine($"Tohle je {konik2.Jmeno}");

            //Velryba hybrid = (Velryba)konik; //běhová chyba
            //hybrid.Plav();

            Savec[] zviratka = new Savec[3];
            zviratka[0] = new Kun("Trop");
            zviratka[1] = new Kun("Harvey");
            zviratka[2] = new Velryba("Janice");

            foreach (Savec zvire in zviratka)
            {
                zvire.PredstavSe();
            }
        }
    }
    class Savec 
    {
        public string Jmeno { get; protected set; }
        public Savec(string jmeno)
        {
            Jmeno = jmeno;
        }
        public void Dychej()
        {
            Console.WriteLine("Nádech ... Výdech ...");
        }
        public void NapijSe()
        {
            Console.WriteLine("Glo glo glo");
        }
        public virtual void PredstavSe() //virtual - dědící třídy mohou "předělat"
        {
            Console.WriteLine("Ja jsem savec");
        }
    }
    class Kun : Savec
    {
        public Kun(string jmeno) : base(jmeno) { }
        public void Cvalej()
        {
            Console.WriteLine("Dup dup...");
        }
        public void PridejKeJmenu(string pridavek)
        {
            Jmeno = Jmeno + " " + pridavek;
        }
        public override void PredstavSe()
        {
            Console.WriteLine( $"Já jsem kůň {Jmeno}.");
        }
    }
    class Velryba : Savec
    {
        public Velryba(string jmeno) : base(jmeno) { }

        public void Plav()
        {
            Console.WriteLine("Šplouch");
        }
        public override void PredstavSe()
        {
            Console.WriteLine($"Já jsem velryba {Jmeno}.");
        }
    }
}
