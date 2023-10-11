using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_21_Pes_a_clovek
{
    internal class Clovek
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }

        public Clovek(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
    }
}
