using System.Collections.Generic;
using System;

namespace _2._Permutations_with_Repetitions
{
    public class Program
    {
        private static string[] elements;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();

            PermuteWR(0);
        }

        private static void PermuteWR(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            PermuteWR(index + 1);

            var used = new HashSet<string> { elements[index] };

            for (int i = index + 1; i < elements.Length; i++)
            {
                if (!used.Contains(elements[i]))
                {
                    Swap(index, i);
                    PermuteWR(index + 1);
                    Swap(index, i);

                    used.Add(elements[i]);
                }

            }
        }

        private static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
