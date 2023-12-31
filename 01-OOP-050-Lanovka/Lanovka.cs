﻿using System;
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
            if (!JeVolnoDole)
                return false;

            if (Zatizeni + clovek.Hmotnost > Nosnost)
                return false;

            _sedacky[0] = clovek;
            return true;
        }
        public Clovek Vystup()
        {
            Clovek vystoupil = _sedacky[Delka - 1]; //ten, co byl na konci
            _sedacky[Delka - 1] = null; //už tam není
            return vystoupil;
        }
        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet, nahoře někdo sedí");

            //projít pole od konce
            for (int i = Delka - 1; i > 0; i--)
            {
                _sedacky[i] = _sedacky[i - 1]; //posunu vše o jeden index výš
            }
            _sedacky[0] = null; //dolů dám prázdno
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
