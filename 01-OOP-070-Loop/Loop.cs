using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_070_Loop
{
    internal class Loop
    {
        private int[] items;
        private int index;

        public int Current
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public Loop(int[] items)
        {
            this.items = items; //chtělo by lépe, abych udělal kopii
            index = 0;

        }

        public void Right()
        {
            index++;
            if (index >= items.Length)
                index = 0;
        }

        public void Right(int count)
        {
            for (int i = 0; i < count; i++)
                Right();
        }

        //public void Right(int count)
        //{
        //    index += count;
        //    while (index >= items.Length)
        //        index -= items.Length;
        //}

        public void Left()
        {
            index--;
            if (index < 0)
                index = items.Length - 1;
        }

        public void Left(int count)
        {
            index -= count;
            while (index < 0)
                index += items.Length;
        }
    }
}
