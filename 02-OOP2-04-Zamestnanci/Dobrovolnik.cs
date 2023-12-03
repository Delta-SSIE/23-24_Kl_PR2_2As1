using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_04_Zamestnanci
{
    internal class Dobrovolnik : Zamestananec
    {
        public Dobrovolnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        public override int Mzda()
        {
            return 0;
        }
    }
}
