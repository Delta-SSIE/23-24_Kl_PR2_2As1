using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal interface IVisitList
    {
        public int Count { get; }
        public void AddPlace(Coords place);
        public Coords GetNext();
    }
}
