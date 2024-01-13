namespace _03.LongestCommonSubsequence
{
    using System;
    internal class Program
    {
        static void Main()
        {
            string string1 = Console.ReadLine()!;
            string string2 = Console.ReadLine()!;

            int[,] lcs = new int[string1.Length + 1, string2.Length + 1];

            for (int row = 1; row < lcs.GetLength(0); row++)
            {
                for (int col = 1; col < lcs.GetLength(1); col++)
                {
                    if (string1[row - 1] == string2[col - 1])
                    {
                        lcs[row, col] = lcs[row - 1, col - 1] + 1;
                    }
                    else
                    {
                        lcs[row, col] = Math.Max(lcs[row - 1, col], lcs[row, col - 1]);
                    }
                }
            }

            Console.WriteLine(lcs[lcs.GetLength(0) - 1, lcs.GetLength(1) - 1]);
        }
    }
}
