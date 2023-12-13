using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal class Item
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }

        public Item(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
