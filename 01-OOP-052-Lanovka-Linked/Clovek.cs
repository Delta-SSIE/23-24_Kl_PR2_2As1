using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_052_Lanovka_Linked
{
    internal class Clovek
    {
        public string Jmeno { get; set; }
        public int Hmotnost { get; set; }

        public Clovek(string jmeno, int hmotnost)
        {
            Jmeno = jmeno;
            Hmotnost = hmotnost;
        }
    }
}
