using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class DieselAuto : DopravniProstredek
    {
        public DieselAuto(double maxRychlost, int pocetMist) : base("automobil", TypPohonu.SpalovaciMotor, maxRychlost, pocetMist)
        {
        }

        public override void Natankuj()
        {
            Console.WriteLine("Plním nádrž naftou");
        }
    }
}