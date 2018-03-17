using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionSortingSearching.Recursion
{
    public static class EightQueensProblem
    {
        private const int BoardLength = 8;

        private static readonly int[,] board;
        private static readonly HashSet<int> attackedRows;
        private static readonly HashSet<int> attackedCols;
        private static readonly HashSet<int> attackedRightDiagonals;
        private static readonly HashSet<int> attackedLeftDiagonals;

        private static int solutionsCounter;

        static EightQueensProblem()
        {
            board = new int[BoardLength, BoardLength];
            attackedRows = new HashSet<int>();
            attackedCols = new HashSet<int>();
            attackedRightDiagonals = new HashSet<int>();
            attackedLeftDiagonals = new HashSet<int>();
            solutionsCounter = 0;
        }

        public static void Solve()
        {
            AttackRow(0);
            Console.WriteLine(solutionsCounter);
        }

        private static void AttackRow(int row)
        {
            if (row == BoardLength)
            {
                PrintSolution();
                solutionsCounter++;
                return;
            }
            for (int col = 0; col < BoardLength; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkCell(row, col);
                    AttackRow(row + 1);
                    UnmarkCell(row, col);
                }
            }
        }

        private static void UnmarkCell(int row, int col)
        {
            board[row, col] = 0;
            attackedCols.Remove(col);
            attackedRows.Remove(row);
            attackedRightDiagonals.Remove(row + col);
            attackedLeftDiagonals.Remove(row - col);
        }

        private static void MarkCell(int row, int col)
        {
            board[row, col] = 1;
            attackedCols.Add(col);
            attackedRows.Add(row);
            attackedRightDiagonals.Add(row + col);
            attackedLeftDiagonals.Add(row - col);
        }

        private static void PrintSolution()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(new string('-', BoardLength * 2));
            for (int i = 0; i < BoardLength; i++)
            {
                for (int j = 0; j < BoardLength; j++)
                {
                    result.Append(board[i, j]);
                }
                result.Append(Environment.NewLine);
            }
            result.AppendLine(new string('-', BoardLength * 2));

            Console.WriteLine(result);
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !attackedCols.Contains(col) && !attackedRows.Contains(row) &&
                !attackedRightDiagonals.Contains(row + col) && !attackedLeftDiagonals.Contains(row - col);
        }
    }
}