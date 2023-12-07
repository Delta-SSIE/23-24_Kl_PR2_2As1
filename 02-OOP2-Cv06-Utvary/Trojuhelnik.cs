using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_Cv06_Utvary
{
    internal class Trojuhelnik : IUtvar
    {
        public double StranaA { get; private set; }
        public double StranaB { get; private set; }
        public double StranaC { get; private set; }

        string IUtvar.Nazev => "Trojúhelník";

        public Trojuhelnik(double stranaA, double stranaB, double stranaC)
        {
            StranaA = stranaA;
            StranaB = stranaB;
            StranaC = stranaC;
        }

        public double GetObvod()
        {
            return StranaA + StranaB + StranaC;
        }

        public double GetObsah()
        {
            double s = GetObvod() / 2;
            return Math.Sqrt(s * (s - StranaA) * (s - StranaB) * (s - StranaC));
        }
    }
}
