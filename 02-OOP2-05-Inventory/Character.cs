using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal class Character
    {
        public string Name { get; private set; }
        public int MaxWeight { get; private set; }

        public int HP { get; private set; }
        public int MaxHP { get; private set; }
        
        private List<Item> _inventory;

        public Character(string name, int maxWeight, int maxHP)
        {
            Name = name;
            MaxWeight = maxWeight;
            HP = MaxHP = maxHP;
            _inventory = new List<Item>();
        }

        public int CarryWeight
        {
            get
            {
                int weight = 0;
                foreach (Item i in _inventory)
                {
                    weight += i.Weight;
                }
                return weight;
            }
        }
        //public int CarryWeight => _inventory.Select(i => i.Weight).Sum();

        /// <summary>
        /// inserts item to inventory
        /// </summary>
        /// <param name="item"></param>
        /// <returns>False, if item is too heavy</returns>
        /// <exception cref="Exception"></exception>
        public bool Take(Item item)
        {
            if (_inventory.Contains(item))
                throw new Exception("Item already carrying");

            if (item.Weight > MaxWeight - CarryWeight)
                return false;

            _inventory.Add(item);
            return true;
        }

        public void Drop(Item item)
        {
            _inventory.Remove(item);
        }

        public string GetItemList()
        {
            string result = "";
            foreach (Item i in _inventory)
            {
                result += i.Name + "\n";
            }
            return result;
        }

    }
}
