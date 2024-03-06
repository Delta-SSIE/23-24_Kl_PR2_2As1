using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unit_testing_02_Rychlostni_skrin
{
    public enum Stupen { Zpatecka, Neutral, Jednicka, Dvojka, Trojka, Ctyrka, Petka, Sestka}
    public class RychlostniSkrin
    {
        public Stupen Zarazeno { get; private set; }
        public int Otacky { get; set; }
        public int MaxOtackyRazeni { get; private init; }

        public RychlostniSkrin(int maxOtackyRazeni)
        {
            if (maxOtackyRazeni < 0)
                throw new ArgumentOutOfRangeException();

            MaxOtackyRazeni = maxOtackyRazeni;

            Zarazeno = Stupen.Neutral;
        }

        public void Nahoru()
        {
            if (Zarazeno != Stupen.Sestka)
                Zarazeno = (Stupen)(Zarazeno + 1);
        }

        public void Dolu()
        {
            throw new NotImplementedException();
        }
    }
}
