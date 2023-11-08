using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv02_Pocitadla
{
    internal class Counter
    {
        public int Count { get; protected set; }
        public virtual void Next()
        {
            Count++;
        }
        public virtual void Reset()
        {
            Count = 0;
        }

    }
}
