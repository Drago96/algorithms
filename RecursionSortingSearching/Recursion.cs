using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursionSortingSearching
{
    public static class Recursion
    {
        public static int ArraySum(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            return array[0] + ArraySum(array.Skip(1).ToArray());
        }

        public static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        public static long Fibonacci(int n)
        {
            Dictionary<int, long> fibNumbers = new Dictionary<int, long> {{1, 1}, {2, 1}};

            return GetFibbonaci(n);

            long GetFibbonaci(int i)
            {
                if (fibNumbers.ContainsKey(i))
                {
                    return fibNumbers[i];
                }

                long fibNumber = GetFibbonaci(i - 1) + GetFibbonaci(i - 2);

                fibNumbers.Add(i, fibNumber);

                return fibNumber;
            }
        }
    }
}
