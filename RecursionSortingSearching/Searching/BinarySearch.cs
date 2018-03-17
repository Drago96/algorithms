using System;
using System.Linq;

namespace RecursionSortingSearching.Searching
{
    public static class BinarySearch<T> where T: IComparable<T>
    {
        public static bool Find(T[] arr, T element)
        {
            arr = arr.OrderBy(x => x).ToArray();
            return Find(0, arr.Length - 1, element, arr);
        }

        private static bool Find(int start, int end, T element, T[] arr)
        {
            if (start > end)
            {
                return false;
            }

            int middleIndex = (start + end) / 2;
            T middleElement = arr[middleIndex];
            int comparisonResult = middleElement.CompareTo(element);

            if (comparisonResult == 0)
            {
                return true;
            }
            else if (comparisonResult == 1)
            {
                return Find(start, middleIndex - 1, element, arr);
            }
            else
            {
                return Find(middleIndex + 1, end, element, arr);
            }
        }
    }
}
