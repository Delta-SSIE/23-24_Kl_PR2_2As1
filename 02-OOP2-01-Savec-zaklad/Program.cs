namespace _02_OOP2_Savec_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kun kobylka = new Kun();
            kobylka.Cvalej();
            kobylka.Dychej();
            kobylka.NapijSe();
            //kobylka.Plav(); //nelze

            Velryba mobyDick = new Velryba();
            mobyDick.Dychej();
            mobyDick.NapijSe();
            mobyDick.Plav();

            Savec konik = new Kun();
            konik.Dychej();
            //konik.Cvalej(); //nelze, vidím jen metody savce kvůli typu proměnné konik

            Kun konik2 = (Kun)konik; //type casting ... vnutím mu typ
            konik2.Cvalej();

            //Velryba hybrid = (Velryba)konik; //běhová chyba
            //hybrid.Plav();

            

        }
    }
    class Savec : Object //není třeba dedičnost psát, z Object se dědí automaticky
    {
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
        public void Cvalej()
        {
            Console.WriteLine("Dup dup...");
        }
    }
    class Velryba : Savec
    {
        public void Plav()
        {
            Console.WriteLine("Šplouch");
        }
    }
}
