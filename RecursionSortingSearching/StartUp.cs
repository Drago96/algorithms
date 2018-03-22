using RecursionSortingSearching.Recursion;

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
            Combinatorics.SwapPermutations(new[] { 3, 3, 2, 1, 3, 3 });

            //int[] arr = MergeSort<int>.Sort(new[] { 3, 2, 1 });
            //Console.WriteLine(string.Join(" ", arr));

            // Console.WriteLine(BinarySearch<int>.Find(new[] { 4, 7, 1, 2, 3, -3 }, -3));
        }
    }
}