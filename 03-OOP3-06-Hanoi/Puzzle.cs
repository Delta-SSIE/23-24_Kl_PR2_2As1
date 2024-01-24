﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_06_Hanoi
{
    internal class Puzzle
    {
        public int Size { get; private set; }

        private Stack<int> leftTower = new Stack<int>();
        private Stack<int> middleTower = new Stack<int>();
        private Stack<int> rightTower = new Stack<int>();

        public bool IsSolved => rightTower.Count == Size;
        public string ErrorMessage = string.Empty;

        public Puzzle(int size)
        {
            Size = size;

            for (int disc = size; disc > 0; disc--)
            {
                leftTower.Push(disc);
            }
        }

        public void Render()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + ": ");
                RenderTower(i);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void RenderTower(int number)
        {
            Stack<int> tower = GetTowerByNo(number);
            int[] discs = tower.ToArray();
            Array.Reverse(discs);
            foreach (int disc in discs)
                Console.Write(disc + " ");
        }

        /// <summary>
        /// Moves disc from one pin to another
        /// </summary>
        /// <param name="from">integer 0 - 3 for source pin</param>
        /// <param name="to">integer 0 - 3 for target pin</param>
        /// <returns>If move was succesful</returns>
        public bool Move (int from, int to)
        {
            try
            {
                Stack<int> fromTower = GetTowerByNo(from);
                Stack<int> toTower = GetTowerByNo(to);
                return Move(fromTower, toTower);
            }
            catch //špatný index věže - GetTowerByNo vyvolá výjimku
            {
                ErrorMessage = "Invalid tower number";
                return false;
            }
        }
        private bool Move(Stack<int> fromTower, Stack<int> toTower)
        {
            //stejný na stejný
            if (fromTower == toTower)
                return true; //nic nedělám, vrátím true

            //prazdný zdroj
            if (fromTower.Count < 1)
            {
                ErrorMessage = "Nothing to take on source tower";
                return false;
            }

            //větší na menší
            if (toTower.Count > 0  && (fromTower.Peek() > toTower.Peek()))
            {
                ErrorMessage = "Cannot put larger disc on small";
                return false;
            }

            int disc = fromTower.Pop();
            toTower.Push(disc);
            ErrorMessage = string.Empty;
            return true;
        }

        private Stack<int> GetTowerByNo(int number)
        {
            return number switch
            {
                0 => leftTower,
                1 => middleTower,
                2 => rightTower,
                _ => throw new ArgumentOutOfRangeException(nameof(number)),
            };
        }
    }
}
