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
        public bool IsAlive => HP > 0;

        public Weapon RightHand { get; private set; } = null;
        public Shield LeftHand { get; private set; } = null;
        public Armor Wearing { get; private set; } = null;
        
        private List<Item> _inventory;
        private Dice _dice;

        public Character(string name, int maxWeight, int maxHP)
        {
            Name = name;
            MaxWeight = maxWeight;
            HP = MaxHP = maxHP;
            _inventory = new List<Item>();
            _dice = new Dice();
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
                if (LeftHand != null)
                {
                    weight += LeftHand.Weight;
                }
                if (RightHand != null)
                {
                    weight += RightHand.Weight;
                }
                if (Wearing != null)
                {
                    weight += Wearing.Weight;
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

        public bool Equip(Item item)
        {
            if (!_inventory.Contains(item))
                return false;

            if (item is Weapon weapon)
            {
                if (RightHand != null)
                {
                    _inventory.Add(RightHand);
                }
                RightHand = weapon;
                _inventory.Remove(item);
                return true;
            }
            if (item is Shield shield)
            {
                if (LeftHand != null)
                {
                    _inventory.Add(LeftHand);
                }
                LeftHand = shield;
                _inventory.Remove(item);
                return true;
            }
            if (item is Armor armor)
            {
                if (Wearing != null)
                {
                    _inventory.Add(Wearing);
                }
                Wearing = armor;
                _inventory.Remove(item);
                return true;
            }
            return false;
        }

        public int GetAttack()
        {
            int attack = RightHand != null ? RightHand.Attack : 0;
            return  attack + _dice.Throw();
        }

        private int GetDefense()
        {
            int defense = LeftHand != null ? LeftHand.Defense : 0;
            defense += Wearing != null ? Wearing.Defense : 0;
            return defense + _dice.Throw();
        }

        public int ResolveAttack(int attack)
        {
            int defense = GetDefense();
            
            int wound = 0;
            
            if (attack > defense)
                wound = attack - defense;

            if (wound > HP)
                wound = HP;

            HP -= wound;
            return wound;
        } 
    }
}
