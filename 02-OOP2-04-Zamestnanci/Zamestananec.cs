using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_04_Zamestnanci
{
    internal abstract class Zamestananec
    {
        public string Jmeno { get; init; }
        public string Prijmeni { get; init; }

        protected Zamestananec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public abstract int Mzda();
    }
}
