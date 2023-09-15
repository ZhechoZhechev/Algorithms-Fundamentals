using System;

namespace _2._Loops_To_Recursion
{
    public class Program
    {
        private static string[] combinations;

        static void Main()
        {
            var nestedNumber = int.Parse(Console.ReadLine()!);
            combinations = new string[nestedNumber];

            GetCombination(0);
        }

        private static void GetCombination(int index)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = 1; i <= combinations.Length; i++)
            {
                combinations[index] = i.ToString();
                GetCombination(index + 1);
            }
        }
    }
}