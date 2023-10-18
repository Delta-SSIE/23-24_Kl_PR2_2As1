using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_060_Paginator
{
    internal class Paginator
    {
        private int pageSize;
        private string[] items;
        public int ItemCount
        {
            get { return items.Length; }
        }

        public int PageCount
        {
            get
            {
                if (ItemCount % pageSize == 0)
                    return ItemCount / pageSize;
                else
                    return ItemCount / pageSize + 1; //to když poslední stránka bude neúplná
            }
        }

        public Paginator(string[] items, int pageSize)
        {
            if (pageSize < 1)
                throw new ArgumentOutOfRangeException();

            this.pageSize = pageSize;
            this.items = items;
        }

        public int GetPageItemCount(int n)
        {
            if (n < 0 || n >= PageCount)
                return 0;
            else if (n < PageCount - 1)
                return pageSize;
            else
                return ItemCount % pageSize;
        }

        public string[] GetPage(int n)
        {
            if (n < 0 || n > PageCount)
                return new string[0];

            int limit = Math.Min(pageSize * (n + 1), ItemCount);
            List<string> pageItems = new List<string>();
            for (int i = pageSize * n; i < limit; i++)
            {
                pageItems.Add(items[i]);
            }

            return pageItems.ToArray();
        }

        public int FindPage(string s)
        {
            int pozice = Array.IndexOf(items, s);

            if (pozice < 0)
                return -1;
            else if (pozice % pageSize == 0)
                return pozice / pageSize + 1;
            else
                return pozice / pageSize + 2;

        }

    }
}
