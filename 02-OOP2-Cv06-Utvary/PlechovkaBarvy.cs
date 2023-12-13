using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_Cv06_Utvary
{
    internal class PlechovkaBarvy
    {
        /// <summary>
        /// Kolik mililitrů je v pixle
        /// </summary>
        public double Objem { get; private set; }
        /// <summary>
        /// Kolik mililitrů je potřeba na 1 cm^2
        /// </summary>
        public double Vydatnost { get; private set; }

        public PlechovkaBarvy(double objem, double vydatnost)
        {
            Objem = objem;
            Vydatnost = vydatnost;
        }
        public override string ToString()
        {
            return $"Plechovka barvy, zbývá jí ještě na {Objem / Vydatnost} cm²";
        }
        public bool Obarvi(IUtvar utvar)
        {
            double spotreba = utvar.GetObsah() * Vydatnost;
            
            if (Objem >= spotreba)
            {
                Objem -= spotreba;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
