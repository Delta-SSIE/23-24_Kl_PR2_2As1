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
        private int _nohy;
        public int Nohy
        {
            get { return _nohy; }
            set
            {
                if (value > _nohy || value < 0) //takhle zajistím, že nohy lze jen ubírat
                    throw new ArgumentOutOfRangeException();

                _nohy = value;
            }
        }
        public Pes(string jmeno)
        {
            Jmeno = jmeno;
            _nohy = 4;
        }
    }
}
