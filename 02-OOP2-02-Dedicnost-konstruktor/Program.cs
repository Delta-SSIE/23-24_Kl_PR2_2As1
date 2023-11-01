namespace _02_OOP2_02_Dedicnost_konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kun kobylka = new Kun("Ferda");
            kobylka.Cvalej();
            kobylka.Dychej();
            kobylka.NapijSe();
            //kobylka.Plav(); //nelze

            Velryba mobyDick = new Velryba("Moby Dick");
            mobyDick.Dychej();
            mobyDick.NapijSe();
            mobyDick.Plav();

            Savec konik = new Kun("Trop");
            konik.Dychej();
            Console.WriteLine($"Tohle je {konik.Jmeno}");
            //konik.Cvalej(); //nelze, vidím jen metody savce kvůli typu proměnné konik

            Kun konik2 = (Kun)konik; //type casting ... vnutím mu typ
            konik2.Cvalej();
            konik2.PridejKeJmenu(", vítěz");
            Console.WriteLine($"Tohle je {konik2.Jmeno}");

            //Velryba hybrid = (Velryba)konik; //běhová chyba
            //hybrid.Plav();



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
    }
    class Velryba : Savec
    {
        public Velryba(string jmeno) : base(jmeno) { }

        public void Plav()
        {
            Console.WriteLine("Šplouch");
        }
    }
}
