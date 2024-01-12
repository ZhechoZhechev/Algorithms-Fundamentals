namespace _01._Fibonacci
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        private static Dictionary<int, long> fibonaccies = new Dictionary<int, long>();
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            long result = CalculateFibonacci(num);
            Console.WriteLine(result);
        }

        private static long CalculateFibonacci(int num)
        {

            if (fibonaccies.ContainsKey(num))
            {
                return fibonaccies[num];
            }

            if (num < 3)
            {
                return 1;
            }

            var result = CalculateFibonacci(num - 1) + CalculateFibonacci(num - 2);
            fibonaccies[num] = result;
            return result;
        }
    }
}
