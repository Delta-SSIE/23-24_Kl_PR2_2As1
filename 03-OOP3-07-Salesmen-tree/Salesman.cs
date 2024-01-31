using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_07_Salesmen_tree
{
    class Salesman
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Sales { get; private set; }
        public List<Salesman> Subordinates { get; private set; }

        public Salesman(string surname, string name, int sales)
        {
            Name = name;
            Surname = surname;
            Sales = sales;
            Subordinates = new List<Salesman>();
        }

        public void AddSubordinate(Salesman subordinate)
        {
            Subordinates.Add(subordinate);
        }

    }
}
