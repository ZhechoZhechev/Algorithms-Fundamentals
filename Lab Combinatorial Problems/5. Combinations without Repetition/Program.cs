using System;

namespace _5._Combinations_without_Repetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] combinations;

        static void Main()
        {
            elements = Console.ReadLine().Split();
            var k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            Combinations(0, 0);
        }

        private static void Combinations(int index, int elementsIndex)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = elementsIndex; i < elements.Length; i++) 
            {
                combinations[index] = elements[i];
                Combinations(index + 1, i + 1);
            }
        }
    }
}