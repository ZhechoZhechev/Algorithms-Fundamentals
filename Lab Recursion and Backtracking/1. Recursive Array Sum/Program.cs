namespace _1.Recursive_Array_Sum
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            var array = Console.ReadLine()!.Split()
                .Select(int.Parse)
                .ToArray();

            var sum = GetSum(0, array);

            Console.WriteLine(sum);
        }

        private static int GetSum(int index, int[] array)
        {
            if (index >= array.Length)
                return 0;

            return array[index] + GetSum(index + 1, array);
        }
    }
}