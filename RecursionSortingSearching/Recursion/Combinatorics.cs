using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursionSortingSearching.Recursion
{
    public static class Combinatorics
    {
        public static void GenerateBitVector(int length)
        {
            GenerateBitVector(0, new int[length]);

            void GenerateBitVector(int index, int[] vector)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join("", vector));
                    return;
                }

                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    GenerateBitVector(index + 1, vector);
                }
            }
        }

        public static void GenerateCombinations(int[] set, int k)
        {
            GenerateCombinations(new int[k], 0, 0);

            void GenerateCombinations(int[] vector, int index, int border)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                    return;
                }

                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenerateCombinations(vector, index + 1, i + 1);
                }
            }
        }

        public static void GenerateCombinationsWithRepetition(int[] set, int k)
        {
            GenerateCombinationsWithRepetition(new int[k], 0, 0);

            void GenerateCombinationsWithRepetition(int[] vector, int index, int border)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                    return;
                }

                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenerateCombinationsWithRepetition(vector, index + 1, i);
                }
            }
        }

        public static void GenerateVariations(int[] set, int k)
        {
            GenerateVariations(new int[k], 0, set);

            void GenerateVariations(int[] vector, int index, int[] numberSet)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                    return;
                }

                for (int i = 0; i < numberSet.Length; i++)
                {
                    vector[index] = numberSet[i];
                    GenerateVariations(vector, index + 1,
                        numberSet.Take(i).Concat(numberSet.Skip(i + 1)).ToArray());
                }
            }
        }

        public static void GenerateVariationsWithRepetition(int[] set, int k)
        {
            GenerateVariationsWithRepetition(new int[k], 0);

            void GenerateVariationsWithRepetition(int[] vector, int index)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                    return;
                }

                foreach (int number in set)
                {
                    vector[index] = number;
                    GenerateVariationsWithRepetition(vector, index + 1);
                }
            }
        }

        public static void GeneratePermutations(int[] set)
        {
            GeneratePermutations(new int[set.Length], 0, set);

            void GeneratePermutations(int[] vector, int index, int[] numbersSet)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                    return;
                }

                for (int i = 0; i < numbersSet.Length; i++)
                {
                    vector[index] = numbersSet[i];
                    GeneratePermutations(vector, index + 1,
                        numbersSet.Take(i).Concat(numbersSet.Skip(i + 1)).ToArray());
                }
            }
        }

        public static void SwapPermutations(int[] set)
        {

            SwapPermutations(0);

            void SwapPermutations(int index)
            {
                if (index == set.Length)
                {
                    Console.WriteLine(string.Join("", set));
                    return;
                }

                SwapPermutations(index + 1);

                HashSet<int> swapped = new HashSet<int> {set[index]};

                for (int i = index + 1; i < set.Length; i++)
                {
                    if (!swapped.Contains(set[i]))
                    {
                        Swap(i, index);
                        SwapPermutations(index + 1);
                        Swap(i, index);
                        swapped.Add(set[i]);
                    }
                }

                void Swap(int firstIndex, int secondIndex)
                {
                    int temp = set[firstIndex];
                    set[firstIndex] = set[secondIndex];
                    set[secondIndex] = temp;
                }
            }
        }
    }
}