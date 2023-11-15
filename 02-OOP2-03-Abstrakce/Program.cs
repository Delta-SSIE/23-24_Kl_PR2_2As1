namespace _02_OOP2_03_Abstrakce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Savec[] zviratka = new Savec[3];
            zviratka[0] = new Kun("Trop");
            zviratka[1] = new Kun("Harvey");
            zviratka[2] = new Velryba("Janice");

            foreach (Savec zvire in zviratka)
            {
                zvire.PredstavSe();
            }

            //Savec karel = new Savec("Karel"); //nelze, abstraktní třídu nejde instancovat
        }
    }
    abstract class Savec
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
        public abstract void PredstavSe(); //jen hlavička "jak se to volá", ne tělo "jak se to dělá"

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
            Console.WriteLine($"Já jsem kůň {Jmeno}.");
        }
    }
    sealed class Velryba : Savec
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

    //public class Vorvan : Velryba //nelze dědit z "sealed" třídy
    //{

    //}
}
