using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._Cinema
{
    public class Program
    {
        private static List<string> nonStaticPeople;
        private static string[] people;

        static void Main()
        {
            nonStaticPeople = Console.ReadLine().Split(", ").ToList();
            people = new string[nonStaticPeople.Count];

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "generate")
            {
                var args = input.Split(" - ");

                var name = args[0];
                var index = int.Parse(args[1]) - 1;

                people[index] = name;

                nonStaticPeople.Remove(name);
            }

            Permutee(0);
        }

        private static void Permutee(int index)
        {
            if (index >= nonStaticPeople.Count)
            {
                PrintPermutations();
                return;
            }

            Permutee(index + 1);

            for (int i = index + 1; i < nonStaticPeople.Count; i++)
            {
                SwapElements(index, i);
                Permutee(index + 1);
                SwapElements(index, i);

            }
        }

        private static void SwapElements(int first, int second)
        {
            var temp = nonStaticPeople[first];
            nonStaticPeople[first] = nonStaticPeople[second];
            nonStaticPeople[second] = temp;
        }

        private static void PrintPermutations()
        {
            var peopleIndex = 0;
            var sb = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] != null)
                {
                    sb.Append($"{people[i]} ");
                }
                else
                {
                    sb.Append($"{nonStaticPeople[peopleIndex++]} ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}