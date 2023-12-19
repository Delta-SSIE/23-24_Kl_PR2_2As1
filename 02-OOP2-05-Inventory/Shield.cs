using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal class Shield : Item
    {
        public int Defense { get; private set; }
        public Shield(string name, int weight, int defense) : base(name, weight)
        {
            Defense = defense;
        }
    }
}
