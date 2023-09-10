using System;

namespace _1._Permutations_without_Repetitions
{
    public class Program
    {
        private static string[] elements;
        private static bool[] used;
        private static string[] permutations;

        static void Main()
        {
            elements = Console.ReadLine().Split();
            permutations = new string[elements.Length];
            used = new bool[elements.Length];

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutations[index] = elements[i];
                    Permute(index + 1);
                    used[i] = false;
                }

            }
        }
    }
}