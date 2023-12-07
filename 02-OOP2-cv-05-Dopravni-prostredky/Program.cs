namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicykl kolo = new Bicykl(45);
            TahaciKacer kachna = new TahaciKacer(4, 8);

            IPojizdny[] pojizdneVeci = { kolo, kachna };

            int pocetKol = 0;
            foreach (IPojizdny vec in pojizdneVeci)
            {
                pocetKol += vec.PocetKol;
            }

            Console.WriteLine($"Věci mají dohromady {pocetKol} koleček");


            Motocykl motorka = new Motocykl(250);
            Console.WriteLine( motorka.PocetMist ); //mám k dispozici všechny metody motocyklu

            IMotorovy motorkaJinak = motorka;
            Console.WriteLine(motorkaJinak.Pohon);  //vidím jen metody a vlastnosti popsané v interface

        }
    }
}
