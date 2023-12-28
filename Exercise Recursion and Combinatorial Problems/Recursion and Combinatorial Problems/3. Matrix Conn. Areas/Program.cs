using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Matrix_Conn._Areas
{
    public class Program
    {
        public class Area
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Size { get; set; }
        }

        private static char[,] matrix;
        private static List<Area> areas;
        private const char visitedChar = 'v';
        private static int size;

        static void Main()
        {
            var rows = int.Parse(Console.ReadLine()!);
            var cols = int.Parse(Console.ReadLine()!);

            matrix = new char[rows, cols];
            areas = new List<Area>();

            for (int row = 0; row < rows; row++) 
            {
                var colElements = Console.ReadLine();

                for (int col = 0; col < cols; col++) 
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    size = 0;
                    FindNeighbours(i, j);

                    if (size != 0)
                    {
                        areas.Add(new Area { Row = i, Col = j, Size = size });
                    }
                }
            }

            Console.WriteLine($"Total areas found: {areas.Count}");

            var sorted = areas.OrderByDescending(x => x.Size)
                .ThenBy(x => x.Row)
                .ThenBy(x => x.Col)
                .ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine($"Area #{i + 1} at ({sorted[i].Row}, {sorted[i].Col}), size: {sorted[i].Size}");
            }

        }

        private static void FindNeighbours(int row, int col)
        {
            if (IsOutsideMatrix(row, col) || IsWall(row, col) || IsVisited(row, col)) 
                return;

            size++;
            matrix[row, col] = visitedChar;

            FindNeighbours(row - 1, col);
            FindNeighbours(row + 1, col);
            FindNeighbours(row, col - 1);
            FindNeighbours(row, col + 1);

        }

        private static bool IsVisited(int row, int col)
            => matrix[row, col] == visitedChar;

        private static bool IsWall(int row, int col)
            => matrix[row, col] == '*';

        private static bool IsOutsideMatrix(int row, int col)
            => row >= matrix.GetLength(0) || row < 0 || col >= matrix.GetLength(1) || col < 0;
    }
}