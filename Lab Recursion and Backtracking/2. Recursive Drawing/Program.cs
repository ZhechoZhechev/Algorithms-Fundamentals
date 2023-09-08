using System;

namespace _2._Recursive_Drawing
{
    internal class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine()!);

            DrawFigure(n);
        }

        private static void DrawFigure(int n)
        {
            if (n <= 0) return;

            Console.WriteLine(new string('*', n));

            DrawFigure(n -1);

            Console.WriteLine(new string('#', n));
        }
    }
}