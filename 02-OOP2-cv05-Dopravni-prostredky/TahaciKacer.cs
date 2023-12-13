using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class TahaciKacer : IPojizdny
    {
        public int PocetKol { get; private set; }
        public double MaxRychlost { get; private set; }

        public TahaciKacer(int pocetKol, double maxRychlost)
        {
            PocetKol = pocetKol;
            MaxRychlost = maxRychlost;
        }
    }
}
