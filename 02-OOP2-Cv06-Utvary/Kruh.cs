using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_Cv06_Utvary
{
    internal class Kruh : IUtvar
    {
        public double Polomer { get; private set; }

        string IUtvar.Nazev => "Kruh";

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }

        public double GetObvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double GetObsah()
        {
            return Math.PI * Polomer * Polomer;
        }

        public override string ToString()
        {
            return $"Kruh o poloměru {Polomer} cm";
        }
    }
}
