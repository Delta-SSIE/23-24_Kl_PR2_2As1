using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    enum TypPohonu
    {
        Manualni,
        SpalovaciMotor,
        Elektromotor
    }
    abstract class DopravniProstredek : IMotorovy
    {
        public string Nazev { get; private set; }
        public TypPohonu Pohon { get; private set; }
        public double MaxRychlost { get; private set; }
        public int PocetMist { get; private set; }

        protected DopravniProstredek(string nazev, TypPohonu pohon, double maxRychlost, int pocetMist)
        {
            Nazev = nazev;
            Pohon = pohon;
            MaxRychlost = maxRychlost;
            PocetMist = pocetMist;
        }

        public abstract void Natankuj();

        public override string ToString()
        {
            return $"Dopravní prostředek ({Nazev}), {PocetMist} míst, max. rychlost {MaxRychlost} km/h";
        }
    }
}
