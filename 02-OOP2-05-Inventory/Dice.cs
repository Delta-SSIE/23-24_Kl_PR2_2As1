using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal class Dice
    {
        private static Random _generator = null;
        public int Sides { get; private set; }

        public Dice(int sides = 6)
        {
            if (_generator == null)
                _generator = new Random();

            Sides = sides;
        }
        public int Throw()
        {
            return _generator.Next(1, Sides + 1);
        }
    }
}
