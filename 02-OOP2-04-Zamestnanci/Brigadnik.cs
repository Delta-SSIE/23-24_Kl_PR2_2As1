using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_04_Zamestnanci
{
    //Dědí ze třídy Zamestnanec
    //Má veřejné vlastnosti Odpracovano(celé číslo, počet odpracovaných hodin) a HodinovaMzda(celé číslo)
    //Mzda() vrací mzdu vypočtenou z předchozích položek
    internal sealed class Brigadnik : Zamestananec
    {
        public int Odpracovano { get; set; }
        public int HodinovaMzda { get; set; }
        public Brigadnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        public override int Mzda()
        {
            return Odpracovano * HodinovaMzda;
        }
    }

}
