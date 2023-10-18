using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_051_Lanovka_index
{
    internal class Lanovka
    {
        public int Delka { get; private set; }
        public int Nosnost { get; private set; }

        private Clovek[] _sedacky;
        private int _indexPrvniSedacky;
        private int _indexPosledniSedacky
        {
            get
            {
                int index = _indexPrvniSedacky - 1;
                if (index < 0)
                    index = Delka - 1;
                return index;
            }
        }

        public Lanovka(int delka, int nosnost)
        {
            Delka = delka;
            _sedacky = new Clovek[delka];

            Nosnost = nosnost;
            _indexPrvniSedacky = 0;
        }
        public int Zatizeni
        {
            get
            {
                int celkem = 0;
                foreach (Clovek clovek in _sedacky)
                {
                    if (clovek != null)
                        celkem += clovek.Hmotnost;
                    //celkem += clovek != null ? clovek.Hmotnost : 0;
                }
                return celkem;
            }
        }
        //public int Zatizeni => _sedacky.Select(x => x != null ? x.Hmotnost : 0).Sum();

        public bool JeVolnoDole
        {
            get
            {
                if (_sedacky[_indexPrvniSedacky] == null)
                    return true;
                else
                    return false;
            }
        }

        public bool JeVolnoNahore
        {
            get
            {
                if (_sedacky[_indexPosledniSedacky] == null)
                    return true;
                else
                    return false;
            }
        }

        public bool Nastup(Clovek clovek)
        {
            if (!JeVolnoDole)
                return false;

            if (Zatizeni + clovek.Hmotnost > Nosnost)
                return false;

            _sedacky[_indexPrvniSedacky] = clovek;
            return true;
        }
        public Clovek Vystup()
        {
            Clovek vystoupil = _sedacky[_indexPosledniSedacky]; //ten, co byl na konci
            _sedacky[_indexPosledniSedacky] = null; //už tam není
            return vystoupil;
        }
        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet, nahoře někdo sedí");

            _indexPrvniSedacky = _indexPosledniSedacky;
            _sedacky[_indexPrvniSedacky] = null; //dolů dám prázdno
        }

        public void Vypis()
        {
            Console.WriteLine("Vypis lanovky:");
            for (int i = 0; i < Delka; i++)
            {
                Clovek kdo = _sedacky[i];
                Console.WriteLine($"{i}: {(kdo == null ? "prazdno" : kdo.Jmeno)}");
            }
            Console.WriteLine("----");
        }

    }
}
