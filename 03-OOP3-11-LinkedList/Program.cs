using System.Diagnostics;

namespace _03_OOP_11_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ints = new LinkedList<int>();

            //ints.AddLast(3);
            //ints.AddLast(4);
            //ints.AddLast(12);
            //ints.AddLast(18);
            //ints.AddFirst(5);

            //foreach (int num in ints)
            //{
            //    Console.WriteLine(num);
            //}

            int count = 10_000_000;

            List<int> list = new List<int>();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < count; i++)
            {
                //ints.AddFirst(i);
                ints.AddLast(i);

                //list.Insert(0, i);
                //list.Add(i);
            }

            sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Reset();
            sw.Start();

            for (int i = 0; i < count; i++)
            {
                //int num = list[i / 2];
                var current = ints.First;
                for (int j = 0; j < i / 2; j++)
                {
                    current = current.Next;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
    }
}
