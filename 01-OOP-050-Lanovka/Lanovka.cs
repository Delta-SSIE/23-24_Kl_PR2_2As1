using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_050_Lanovka
{
    internal class Lanovka
    {
        public int Delka { get; private set; }
        public int Nosnost { get; private set; }

        private Clovek[] _sedacky;

        public Lanovka(int delka, int nosnost)
        {
            Delka = delka;
            _sedacky = new Clovek[delka];

            Nosnost = nosnost;
        }
        public int Zatizeni
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool JeVolnoDole
        {
            get
            {
                if (_sedacky[0] == null)
                    return true;
                else
                    return false;
            }
        }
        //public bool JeVolnoDole => _sedacky[0] == null;

        public bool JeVolnoNahore
        {
            get
            {                
                if (_sedacky[Delka - 1] == null)
                    return true;
                else
                    return false;                
            }
        }

        public bool Nastup(Clovek clovek)
        {
            throw new NotImplementedException();
        }
        public Clovek Vystup()
        {
            throw new NotImplementedException();
        }
        public void Jed()
        {
            throw new NotImplementedException();
        }
    }
}
