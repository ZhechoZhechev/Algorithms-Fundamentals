using System;

namespace _3._Variations_without_Repetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] variations;
        private static bool[] used;

        static void Main()
        {
            elements = Console.ReadLine().Split();
            var k = int.Parse(Console.ReadLine());
            variations = new string[k];
            used = new bool[elements.Length];

            Variations(0);
        }

        private static void Variations(int index)
        {
            if(index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for(int i = 0; i < elements.Length; i++) 
            {
                if (!used[i]) 
                {
                    used[i] = true;
                    variations[index] = elements[i];
                    Variations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}