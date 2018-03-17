using System;
using System.Linq;

namespace RecursionSortingSearching.Sorting
{
    public static class MergeSort<T> where T : IComparable<T>
    {
        public static T[] Sort(T[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        private static void Sort(T[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int middle = (start + end) / 2;

            Sort(array, start, middle);
            Sort(array, middle + 1, end);
            Merge(array, start, middle, end);
        }

        private static void Merge(T[] array, int start, int middle, int end)
        {
            if (array[middle].CompareTo(array[middle+1]) == -1)
            {
                return;
            }

            T[] left = array.Skip(start).Take(middle - start + 1).ToArray();
            T[] right = array.Skip(middle + 1).Take(end - middle).ToArray();

            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = start; i <= end; i++)
            {
                if (leftIndex >= left.Length)
                {
                    array[i] = right[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex >= right.Length)
                {
                    array[i] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    if (left[leftIndex].CompareTo(right[rightIndex]) < 1)
                    {
                        array[i] = left[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        array[i] = right[rightIndex];
                        rightIndex++;
                    }
                }
            }
        }
    }
}
