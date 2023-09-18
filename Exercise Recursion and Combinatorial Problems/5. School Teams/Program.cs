using System.Collections.Generic;
using System.Linq;
using System;

namespace _5._School_Teams
{
    public class Program
    {
        static void Main()
        {
            {
                var girls = Console.ReadLine().Split(", ");
                var girlsComb = new string[3];
                var girlsCombs = new List<string[]>();
                var boys = Console.ReadLine().Split(", ");
                var boysComb = new string[2];
                var boysCombs = new List<string[]>();

                GetCombinations(0, 0, girls, girlsComb, girlsCombs);
                GetCombinations(0, 0, boys, boysComb, boysCombs);

                foreach (var gComb in girlsCombs)
                {
                    foreach (var bcomb in boysCombs)
                    {
                        Console.WriteLine($"{string.Join(", ", gComb)}, {string.Join(", ", bcomb)}");
                    }
                }
            }

        }
        private static void GetCombinations(int idx, int start, string[] elements, string[] comb, List<string[]> combs)
        {
            if (idx >= comb.Length)
            {
                combs.Add(comb.ToArray());
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                comb[idx] = elements[i];
                GetCombinations(idx + 1, i + 1, elements, comb, combs);
            }
        }

    }
}