using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_052_Lanovka_Linked
{
    internal class Lanovka
    {
        public int Delka { get; private set; }
        public int Nosnost { get; private set; }

        private Sedacka _prvni;
        private Sedacka _posledni;

        public Lanovka(int delka, int nosnost)
        {
            Delka = delka;
            Nosnost = nosnost;

            VytvorSedacky();
        }

        private void VytvorSedacky()
        {
            _posledni = new Sedacka();

            Sedacka posledniVytvorena = _posledni;

            for (int i = 0; i < Delka - 1; i++)
            {
                Sedacka novaSedacka = new Sedacka();
                posledniVytvorena.Dalsi = novaSedacka;

                posledniVytvorena = novaSedacka;
            }

            _prvni = posledniVytvorena;
        }

        public bool JeVolnoNahore
        {
            get
            {
                return _posledni.Pasazer == null;
            }
        }

        public bool JeVolnoDole
        {
            get
            {
                return _prvni.Pasazer == null;
            }
        }

        public bool Nastup (Clovek pasazer)
        {
            if (!JeVolnoDole)
                return false;

            //ToDo: zkontroluj hmotnost

            _prvni.Pasazer = pasazer;
            return true;
        }

        public Clovek Vystup()
        {
            Clovek pasazer = _posledni.Pasazer;
            _posledni.Pasazer = null;
            return pasazer;
        }

        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("nelze jet, nahoře někdo sedí");

            _posledni = _posledni.Dalsi;
            
            Sedacka novaPrvni = new Sedacka();
            _prvni.Dalsi = novaPrvni;
            _prvni = novaPrvni;
        }
    }
}
