using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_Test_reseni
{
    internal class Festival
    {
        public string Nazev { get; private set; }
        public int Kapacita { get; private set; }
        public int Prodano { get; private set; }
        public bool Obsazeno => Prodano >= Kapacita;
        public int Volno => Kapacita - Prodano;

        public Festival(string nazev, int kapacita)
        {
            if (nazev == string.Empty)
                throw new ArgumentException(nameof(nazev));

            Nazev = nazev;


            if (kapacita <= 0)
                throw new ArgumentException(nameof(kapacita));
            Kapacita = kapacita;

            Prodano = 0;
        }
        public void ProdejVstupenky(int kolik)
        {
            if (kolik > Volno)
                throw new ArgumentOutOfRangeException("Nelze prodat víc vstupenek, než je Volno");
            Prodano += kolik;
        }
        public void VratVstupenky(int kolik)
        {
            if (kolik > Prodano)
                throw new ArgumentOutOfRangeException("Nelze vrátit víc vstupenek, než je prodáno");
            Prodano -= kolik;
        }
        public string Popis()
        {
            return $"Festival \"{Nazev}\", obsazenost {Prodano}/{Kapacita}";
        }
    }
}
