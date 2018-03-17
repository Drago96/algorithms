using System;
using System.Text;

namespace RecursionSortingSearching.Recursion
{
    public static class LabyrinthPaths
    {
        private static char[][] labyrinth;

        public static void Solve()
        {
            ReadLabyrinth();
            FindPaths(0, 0);
        }

        private static void ReadLabyrinth()
        {
            int rows = int.Parse(Console.ReadLine());

            labyrinth = new char[rows][];
            for (int row = 0; row < rows; row++)
            {
                labyrinth[row] = Console.ReadLine().ToCharArray();
            }
        }

        private static void FindPaths(int row, int col)
        {
            if (IsForbidden(row, col))
            {
                return;
            }

            if (labyrinth[row][col] == 'e')
            {
                PrintLabyrinth();
                return;
            }

            labyrinth[row][col] = 'D';
            FindPaths(row + 1, col);

            labyrinth[row][col] = 'U';
            FindPaths(row - 1, col);

            labyrinth[row][col] = 'R';
            FindPaths(row, col + 1);

            labyrinth[row][col] = 'L';
            FindPaths(row, col - 1);

            labyrinth[row][col] = '-';
        }

        private static void PrintLabyrinth()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(new string('+', labyrinth[0].Length * 2));
            foreach (var row in labyrinth)
            {
                result.AppendLine(string.Join("", row));
            }
            result.AppendLine(new string('+', labyrinth[0].Length * 2));
            Console.WriteLine(result);
        }

        private static bool IsForbidden(int row, int col)
        {
            return row < 0 || col < 0 || row >= labyrinth.Length || col >= labyrinth[0].Length
                   || (labyrinth[row][col] != 'e' && labyrinth[row][col] != '-');
        }
    }
}