using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class QueueVisitList : IVisitList
    {
        private Queue<Coords> _queue = new();

        public int Count => _queue.Count;

        public void AddPlace(Coords place)
        {
            _queue.Enqueue(place);
        }

        public Coords GetNext()
        {
            return _queue.Dequeue();
        }
    }
}
