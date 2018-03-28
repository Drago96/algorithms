using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionSortingSearching.Searching
{
    public static class Needles
    {
        public static void Solve(int[] input, int[] pins)
        {
            PrepareArray(input);
            foreach (var pin in pins)
            {
                Console.WriteLine(FindPosition(pin, input));
            }
        }

        private static int FindPosition(int pin, int[] input)
        {
            int middle = (0 + input.Length - 1) / 2;
            return Search(0, middle, input.Length - 1, pin, input);
        }

        private static int Search(int left, int middle, int right, int pin, int[] input)
        {
            if (middle == 0)
            {
                if (pin <= input[middle])
                {
                    return 0;
                }
                return 1;
            }
            if (middle == input.Length - 1)
            {
                if (pin <= input[middle])
                {
                    return input.Length - 1;
                }
                return input.Length;
            }

            if (input[middle] >= pin)
            {
                if (input[middle - 1] < pin)
                {
                    return middle;
                }
                return Search(left, (left + middle) / 2, middle, pin, input);
            }

            return Search(middle + 1, (middle + right) / 2, right, pin, input);
        }

        public static void PrepareArray(int[] input)
        {
            int currentNumber = input[input.Length - 1];
            for (int i = input.Length-1; i >=0; i--)
            {
                if (input[i] == 0)
                {
                    input[i] = currentNumber;
                }
                else
                {
                    currentNumber = input[i];
                }
            }
        }
    }
}
