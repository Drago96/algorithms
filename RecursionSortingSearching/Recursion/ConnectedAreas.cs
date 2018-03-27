using System;

namespace RecursionSortingSearching.Recursion
{
    public static class ConnectedAreas
    {
        private static int connectedAreas;

        static ConnectedAreas()
        {
            connectedAreas = 0;
        }

        public static void Solve(char[][] input)
        {
            FindNextArea(0, 0, input);
            Console.WriteLine(connectedAreas);
        }

        private static void FindNextArea(int row, int col, char[][] input)
        {
            if (row == input.Length)
            {
                return;
            }

            if (col == input[0].Length)
            {
                FindNextArea(row + 1, 0, input);
                return;
            }

            if (input[row][col] != '-' && input[row][col] != '*')
            {
                connectedAreas++;
                MarkCells(row, col, input);
            }

            FindNextArea(row, col + 1, input);

        }

        private static void MarkCells(int row, int col, char[][] input)
        {
            if (row < 0 || row >= input.Length || col < 0 || col >= input[0].Length)
            {
                return;
            }
            if (input[row][col] == '*' || input[row][col] == '-')
            {
                return;
            }

            input[row][col] = '-';

            MarkCells(row + 1, col, input);
            MarkCells(row - 1, col, input);
            MarkCells(row, col + 1, input);
            MarkCells(row, col - 1, input);

        }
    }
}
