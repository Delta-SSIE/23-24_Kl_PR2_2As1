using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class Flotila
    {
        private List<DopravniProstredek> _vozidla = new List<DopravniProstredek>();

        //public int Velikost => _vozidla.Count;
        public int Velikost
        {
            get
            {
                return _vozidla.Count;
            }
        }

        //public int Kapacita => _vozidla.Select(x => x.PocetMist).Sum();
        public int Kapacita
        {
            get
            {
                int kapacita = 0;
                foreach (DopravniProstredek dp in _vozidla)
                {
                    kapacita += dp.PocetMist;
                }
                return kapacita;
            }
        }

        //public TypPohonu[] Pohony => (new HashSet<TypPohonu>(_vozidla.Select(x => x.Pohon))).ToArray();
        public TypPohonu[] Pohony
        {
            get
            {
                List<TypPohonu> pohony = new List<TypPohonu>();
                foreach (DopravniProstredek dp in _vozidla)
                {
                    if (!pohony.Contains(dp.Pohon))
                        pohony.Add(dp.Pohon);
                }
                return pohony.ToArray();
            }
        }

        public void PridejVozidlo(DopravniProstredek vozidlo)
        {
            if (_vozidla.Contains(vozidlo))
                throw new Exception("Nelze přidat stejné vozidlo do flotily dvakrát");

            _vozidla.Add(vozidlo);
        }

        public void OdeberVozidlo(DopravniProstredek vozidlo)
        {
            if (!_vozidla.Contains(vozidlo))
                throw new Exception("Nelze odebrat z flotily vozidlo, které neobsahuje");

            _vozidla.Remove(vozidlo);
        }

        public void Natankuj()
        {
            foreach (DopravniProstredek dp in _vozidla)
            {
                dp.Natankuj();
            }
        }

        // Bonusová
        public void OdvezRychle(int pocetLidi)
        {
            if (pocetLidi > Kapacita)
            {
                Console.WriteLine("Tolik lidí neodvezu");
                return;
            }

            //seradim kopii flotily od nejrychlejsich vozidle
            DopravniProstredek[] serazenaFlotila =  _vozidla.OrderByDescending(x => x.MaxRychlost)
                                                            .ThenByDescending(x => x.PocetMist)
                                                            .ToArray(); 
            
            //budu hledat posledni, ktery jeste potrebuju - ten je nejpomalejsi
            DopravniProstredek nejpomalejsi = serazenaFlotila[0];
            
            int zbyvaOdvezt = pocetLidi;

            //postupne prochazim vsechna vozidla, snizuju pocet lidi, ktere je jeste potreba odvezt
            foreach (DopravniProstredek dp in serazenaFlotila) 
            {
                nejpomalejsi = dp;
                if (zbyvaOdvezt >= dp.PocetMist) //uz odvezu vsechny, zastavim transport
                    break;
                zbyvaOdvezt -= dp.PocetMist;
            }

            Console.WriteLine($"Rychlost transportu je {nejpomalejsi.MaxRychlost} km/h.");
            Console.WriteLine();

            foreach (DopravniProstredek dp in _vozidla)
            {
                if (dp != nejpomalejsi)
                { 
                    Console.WriteLine($"{dp.Nazev}: {dp.PocetMist} osob");
                }
                else
                {
                    Console.WriteLine($"{dp.Nazev}: {zbyvaOdvezt} osob");
                    break;
                }
            }
        }

    }
}
