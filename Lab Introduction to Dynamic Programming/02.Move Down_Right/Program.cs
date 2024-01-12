namespace _02.Move_Down_Right
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine()!);
            int cols = int.Parse(Console.ReadLine()!);

            int[,] matrix = new int[rows, cols];
            int[,] sums = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine()!
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            sums[0, 0] = matrix[0, 0];

            for (int i = 1; i < rows; i++)
            {
                var sum = sums[0, i - 1] + matrix[0, i];
                sums[0, i] = sum;
            }

            for (int i = 1; i < cols; i++)
            {
                var sum = sums[i - 1, 0] + matrix[i, 0];
                sums[i, 0] = sum;
            }

            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    var sum = Math.Max(sums[row - 1, col], sums[row, col - 1]) + matrix[row, col];
                    sums[row, col] = sum;
                }
            }

            var path = new Stack<string>();
            var curRow = rows - 1;
            var curCol = cols - 1;
            while (curRow > 0 && curCol > 0)
            {
                path.Push($"[{curRow}, {curCol}]");
                var up = sums[curRow - 1, curCol];
                var left = sums[curRow, curCol - 1];

                if (up > left)
                {
                    curRow -= 1;

                }
                else
                {
                    curCol -= 1;

                }
            }

            while (curRow > 0) 
            {
                path.Push($"[{curRow}, {curCol}]");
                curRow -= 1;

            }

            while (curCol > 0)
            {
                path.Push($"[{curRow}, {curCol}]");
                curCol -= 1;

            }

            path.Push($"[{curRow}, {curCol}]");
            Console.WriteLine(string.Join(" ", path));
        }
    }
}
