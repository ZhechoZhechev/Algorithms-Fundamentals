using System.Collections.Generic;
using System;

namespace _6._Word_Cruncher
{
    public class Program
    {
        private static Dictionary<int, List<string>> wordsByIdx;
        private static Dictionary<string, int> wordsCount;
        private static LinkedList<string> usedWords;
        private static string target;
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ");

            target = Console.ReadLine();

            wordsByIdx = new Dictionary<int, List<string>>();
            wordsCount = new Dictionary<string, int>();
            usedWords = new LinkedList<string>();

            foreach (var word in input)
            {
                var idx = target.IndexOf(word);

                if (idx == -1)
                {
                    continue;
                }

                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word] += 1;
                    continue;
                }

                wordsCount[word] = 1;

                while (idx != -1)
                {
                    if (!wordsByIdx.ContainsKey(idx))
                    {
                        wordsByIdx[idx] = new List<string>();

                    }

                    wordsByIdx[idx].Add(word);

                    idx = target.IndexOf(word, idx + 1);


                }
            }

            GetSolution(0);
        }

        private static void GetSolution(int idx)
        {
            if (idx == target.Length)
            {
                Console.WriteLine(string.Join(" ", usedWords));
                return;
            }

            if (!wordsByIdx.ContainsKey(idx))
            {
                return;
            }

            foreach (var word in wordsByIdx[idx])
            {
                if (wordsCount[word] == 0)
                {
                    continue;
                }

                wordsCount[word] -= 1;
                usedWords.AddLast(word);

                GetSolution(idx + word.Length);

                wordsCount[word] += 1;
                usedWords.RemoveLast();
            }
        }
    }
}