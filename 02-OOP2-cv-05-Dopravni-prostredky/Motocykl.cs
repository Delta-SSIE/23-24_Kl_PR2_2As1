using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class Motocykl : DopravniProstredek
    {
        public Motocykl(double maxRychlost) : base("motocykl", TypPohonu.SpalovaciMotor, maxRychlost, 2)
        {
        }

        public override void Natankuj()
        {
            Console.WriteLine("Plním nádrž benzínem");
        }
    }
}
