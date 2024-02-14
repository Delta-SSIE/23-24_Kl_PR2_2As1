using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class StackVisitList : IVisitList
    {
        private Stack<Coords> _stack = new();

        public int Count => _stack.Count;

        public void AddPlace(Coords place)
        {
            _stack.Push(place);
        }

        public Coords GetNext()
        {
            return _stack.Pop();
        }
    }
}
