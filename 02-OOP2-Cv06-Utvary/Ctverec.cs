using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_Cv06_Utvary
{
    internal sealed class Ctverec : IUtvar
    {
        public double Strana { get; private set; }

        string IUtvar.Nazev => "Čtverec";

        public Ctverec(double strana)
        {
            Strana = strana;
        }

        public double GetObvod()
        {
            return 4 * Strana;
        }

        public double GetObsah()
        {
            return Strana * Strana;
        }

        public override string ToString()
        {
            return $"Čtverec o straně {Strana} cm";
        }
    }
}
