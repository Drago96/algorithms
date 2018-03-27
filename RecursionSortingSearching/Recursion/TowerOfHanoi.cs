using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionSortingSearching.Recursion
{
    public static class TowerOfHanoi
    {
        private static Stack<int> firstRod;
        private static Stack<int> secondRod;
        private static Stack<int> thirdRod;

        private static int stepsTaken;

        static TowerOfHanoi()
        {
            firstRod = new Stack<int>();
            secondRod = new Stack<int>();
            thirdRod = new Stack<int>();
            stepsTaken = 0;
        }

        public static void Solve(int n)
        {
            InitializeFirstRod(n);

            MoveDisks(n, firstRod, thirdRod, secondRod);

            Console.WriteLine(stepsTaken);
            Console.WriteLine(string.Join(" ", thirdRod));
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destination.Push(source.Pop());
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, spare, destination);
                stepsTaken++;
                destination.Push(source.Pop());
                MoveDisks(bottomDisk - 1, spare, destination, source);
            }
        }

        private static void InitializeFirstRod(int n)
        {
            for (int i = n; i > 0; i--)
            {
                firstRod.Push(i);
            }
        }
    }
}
