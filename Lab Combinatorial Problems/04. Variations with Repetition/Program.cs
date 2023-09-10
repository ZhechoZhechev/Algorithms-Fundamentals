using System;

namespace _4._Variations_with_Repetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] variations;

        static void Main()
        {
            elements = Console.ReadLine().Split();
            var k = int.Parse(Console.ReadLine());
            variations = new string[k];

            Variations(0);
        }

        private static void Variations(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                    variations[index] = elements[i];
                    Variations(index + 1);
            }
        }
    }
}