using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_04_Zamestnanci
{
    //Firma
    //Má veřejné metody Zamestnej(zamestnanec) a Propust(zamestnanec), kterým předáme instanci nějakého zaměstnance a firma si jej připíše na svůj seznam. (Nápověda: použijte List - nebo by se hodil HashSet, ale ten si musíte dohledat)
    internal class Firma
    {
        private List<Zamestananec> _personal;

        public Firma()
        {
            _personal = new List<Zamestananec>();
        }

        public void Zamestnej(Zamestananec osoba)
        {
            if (!_personal.Contains(osoba))
                _personal.Add(osoba);
        }
        public void Propust(Zamestananec osoba)
        {
            _personal.Remove(osoba);
        }
        //Má veřejnou metodu Vyplata, která vypíše pod sebe na řádky všechny zaměstnance spolu s částkou, která jim bude vyplacena a pod to napíše celkovou sumu výplat.
        public void Vyplata()
        {
            int celkem = 0;
            foreach (Zamestananec z in _personal)
            {
                int mzda = z.Mzda();
                celkem += mzda;
                Console.WriteLine($"{z.Prijmeni}, {z.Jmeno} : {mzda}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Celkem: {celkem}");
        }


    }
}
