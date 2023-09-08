using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Find_All_Paths_in_a_Labyrinth
{
    public class Program
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine()!);
            var cols = int.Parse(Console.ReadLine()!);

            var labyrinth = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var colchars = Console.ReadLine();

                for (int j = 0; j < colchars.Length; j++)
                {
                    labyrinth[i, j] = colchars[j];
                }
            }

            FindPaths(labyrinth, 0, 0, new List<string>(), string.Empty);
        }

        private static void FindPaths(char[,] labyrinth, int row, int col, List<string> directions, string direction)
        {

            if (!IsInBoundries(row, col, labyrinth)) return;
            if (labyrinth[row, col] == '*' || labyrinth[row, col] == 'F') return;

            directions.Add(direction);

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine(string.Join("", directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            labyrinth[row, col] = 'F';

            FindPaths(labyrinth, row - 1, col, directions, "U"); //UP
            FindPaths(labyrinth, row + 1, col, directions, "D"); //DOWN
            FindPaths(labyrinth, row, col - 1, directions, "L"); //LEFT
            FindPaths(labyrinth, row, col + 1, directions, "R"); //RIGHT

            labyrinth[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }

        private static bool IsInBoundries(int row, int col, char[,] labyrinth)
        {
            if (row < 0 || row >= labyrinth.GetLength(0) ||
                col < 0 || col >= labyrinth.GetLength(1))
            {
                return false;

            }

            return true;
        }
    }
}