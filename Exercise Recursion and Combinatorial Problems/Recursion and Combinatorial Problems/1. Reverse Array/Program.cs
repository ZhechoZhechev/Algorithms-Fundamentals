using System;

namespace _1._Reverse_Array
{
    public class Program
    {
        private static string[] input;
        static void Main()
        {
            input = Console.ReadLine().Split();

            ReverseAray(0);
        }

        private static void ReverseAray(int index)
        {
            if (index >= input.Length / 2)
            {
                Console.WriteLine(string.Join(" ", input));
                return;

            }

            SwapElements(index);
            ReverseAray(index + 1);
        }

        private static void SwapElements(int index)
        {
            var temp = input[index];
            input[index] = input[input.Length - index - 1];
            input[input.Length - index - 1] = temp;
        }
    }
}