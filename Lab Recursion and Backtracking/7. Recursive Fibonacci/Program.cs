using System;

namespace _7._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine()!);

            var result = CalcFibonacci(num);

            Console.WriteLine(result);
        }

        private static long CalcFibonacci(int num)
        {
            if (num <= 1) return 1;

            return CalcFibonacci(num - 1) + CalcFibonacci(num - 2);
        }
    }
}