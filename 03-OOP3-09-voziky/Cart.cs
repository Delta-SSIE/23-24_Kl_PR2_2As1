using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_0X_voziky
{
    internal class Cart
    {
        public int ID { get; init; }
        public int Mileage { get; set; }
        public int AvailableAt { get; set; }

        public Cart(int id)
        {
            ID = id;
        }
    }
}
