using System;

namespace _4._Recursive_Factorial
{
    public class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine()!);

            var sum = CalcFactorial(n);

            Console.WriteLine(sum);
        }

        private static int CalcFactorial(int n)
        {
            if (n == 0) return 1;

            return n * CalcFactorial(n - 1);
        }
    }
}