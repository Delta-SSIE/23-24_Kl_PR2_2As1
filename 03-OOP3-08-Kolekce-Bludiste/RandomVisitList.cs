using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class RandomVisitList : IVisitList
    {
        List<Coords> _list = new();
        Random _random = new Random();

        public int Count => _list.Count;

        public void AddPlace(Coords place)
        {
            _list.Add(place);
        }

        public Coords GetNext()
        {
            int randomIndex = _random.Next(Count);
            Coords place = _list[randomIndex];
            _list.RemoveAt(randomIndex);
            return place;
        }
    }
}
