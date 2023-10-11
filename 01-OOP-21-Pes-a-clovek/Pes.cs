using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_21_Pes_a_clovek
{
    internal class Pes
    {
        public string Jmeno { get; private set; }
        public Clovek Pan { get; set; }
        public Pes(string jmeno)
        {
            Jmeno = jmeno;
        }
    }
}
