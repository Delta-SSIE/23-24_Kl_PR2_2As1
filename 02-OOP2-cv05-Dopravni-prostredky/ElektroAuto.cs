using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class ElektroAuto : DopravniProstredek
    {
        public ElektroAuto(double maxRychlost, int pocetMist) : base("automobil", TypPohonu.Elektromotor, maxRychlost, pocetMist)
        {
        }

        public override void Natankuj()
        {
            Console.WriteLine("Připojuji na nabíječku");
        }
    }
}
