using System;
using System.Collections.Generic;

namespace RecursionSortingSearching.Recursion
{
    public static class Words
    {
        private static int count;
        private static bool[] used;

        static Words()
        {
            count = 0;
        }

        public static void Solve(string input)
        {
            used = new bool[input.Length];
            FindWords(0, input, ' ');
            Console.WriteLine(count);
        }

        private static void FindWords(int index, string input, char previousChar)
        {
            if (index == input.Length)
            {
                count++;
                return;
            }

            HashSet<int> repetitions = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!used[i] && input[i] != previousChar && !repetitions.Contains(input[i]))
                {
                    used[i] = true;
                    FindWords(index + 1, input, input[i]);
                    used[i] = false;
                    repetitions.Add(input[i]);
                }
            }
        }
    }
}
