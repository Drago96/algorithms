using RecursionSortingSearching.Recursion;
using RecursionSortingSearching.Searching;

namespace RecursionSortingSearching
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            // Combinatorics.GenerateCombinationsWithRepetition(new[] { 1, 2, 3, 4, 5 }, 3);
            // Console.WriteLine(Recursion.Fibonacci(1000));
            // EightQueensProblem.Solve();
            // LabyrinthPaths.Solve();
            // Combinatorics.SwapPermutations(new[] { 3, 3, 2, 1, 3, 3 });
            // TowerOfHanoi.Solve(3);
            // ConnectedAreas.Solve(new []{new []{' ', ' ', ' ', '*', ' ', ' ', ' '}});
            // Words.Solve("nopqrstuvw");
            Needles.Solve(new int[] { 3, 5, 11, 0, 0, 0, 12, 12, 0, 0, 0, 12, 12, 70, 71, 0, 90, 123, 140, 150, 166, 190, 0 }, new int[] { 5, 13, 90, 1, 70 ,75 ,7, 188, 12 });

            //int[] arr = MergeSort<int>.Sort(new[] { 3, 2, 1 });
            //Console.WriteLine(string.Join(" ", arr));

            // Console.WriteLine(BinarySearch<int>.Find(new[] { 4, 7, 1, 2, 3, -3 }, -3));
        }
    }
}