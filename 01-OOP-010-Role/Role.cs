using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_010_Role
{
    internal class Role
    {
        public string Barva { get; private set; } //automatická vlastnost
        //public string Barva;
        //public double Delka { get; private set; }

        private double _delka; //úplná vlastnost
        public double Delka
        {
            get { return _delka; }

            set
            {
                if (value < 0) //zkontroluju, že neukládám pitomost
                    throw new ArgumentOutOfRangeException();

                _delka = value; //chráněným způsobem zapíšu
            }
        }

        public Role(string barva, double delka)
        {
            Barva = barva;
            Delka = delka;
        }

        public Role() //přetížení konstruktoru - stejný název, jiná sada parametrů
        {
            Barva = "";
            Delka = 0;
        }

        public override string ToString()
        {
            return $"Role papíru, barva {Barva}, zbývá {Delka} cm";
        }

    }
}
