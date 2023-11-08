namespace _01_OOP_Test_reseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Festival festival = new Festival("Spanilá jízda", 500);
            Console.WriteLine("Prodáno: " + festival.Prodano); //vypíše 0
            Console.WriteLine("Název: " + festival.Nazev); //vypíše Spanilá jízda
            Console.WriteLine("Kapacita: " + festival.Kapacita); //vypíše 500


            festival.ProdejVstupenky(20);

            Console.WriteLine("Prodáno: " + festival.Prodano); //vypíše 20
            Console.WriteLine("Obsazeno: " + festival.Obsazeno); //vypíše false


            festival.VratVstupenky(2);

            Console.WriteLine("Prodáno: " + festival.Prodano); //vypíše 18
            Console.WriteLine("Volné lístky: " + festival.Volno); //vypíše 482
            Console.WriteLine("Obsazeno: " + festival.Obsazeno); //vypíše false
            Console.WriteLine("Popis: " + festival.Popis()); //vypíše:
                                                             //Festival "Spanilá jízda", obsazenost 18/500

            try
            {
                festival.VratVstupenky(20); //vyvolá výjimku
                Console.WriteLine("Zobrazení tohoto textu znamená chybu");
            }
            catch (Exception e)
            {
                Console.WriteLine("Vhodně vyvolaná výjimka při vracení");
            }


            try
            {
                festival.ProdejVstupenky(2000); //vyvolá výjimku
                Console.WriteLine("Zobrazení tohoto textu znamená chybu");
            }
            catch (Exception e)
            {
                Console.WriteLine("Vhodně vyvolaná výjimka při prodeji");
            }


            festival.ProdejVstupenky(482);
            Console.WriteLine("Prodáno: " + festival.Prodano); //vypíše 500
            Console.WriteLine("Volné lístky: " + festival.Volno); //vypíše 0
            Console.WriteLine("Obsazeno: " + festival.Obsazeno); //vypíše true


            festival.VratVstupenky(5);
            Console.WriteLine("Obsazeno: " + festival.Obsazeno); //vypíše false


            try
            {
                Festival chyba = new Festival("Chyba lávky", -500); //vyvolá výjimku
                Console.WriteLine("Zobrazení tohoto textu znamená chybu");
            }
            catch (Exception e)
            {
                Console.WriteLine("Vhodně vyvolaná výjimka při insatncování třídy");
            }
        }
    }
}
