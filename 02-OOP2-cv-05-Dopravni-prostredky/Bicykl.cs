using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class Bicykl : DopravniProstredek, IPojizdny
    {
        public Bicykl(double maxRychlost) : base("bicykl", TypPohonu.Manualni, maxRychlost, 1)
        {
        }

        public int PocetKol => 2;

        public override void Natankuj()
        {
            Console.WriteLine("Jdu na svačinu.");
        }
    }
}
