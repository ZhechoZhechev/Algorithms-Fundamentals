namespace TextAndThreeStrings
{
    using System;

    internal class Program
    {
        static string FindShortestSubstring(string text, string s1, string s2, string s3)
        {
            int start = 0;
            int end = text.Length;

            while (ContainsAllSubstrings(text.Substring(start, end - start), s1, s2, s3))
            {
                start++;
            }

            while (ContainsAllSubstrings(text.Substring(start - 1, end - start), s1, s2, s3))
            {
                end--;
            }

            start--;
            return text[start..end];
        }

        static bool ContainsAllSubstrings(string text, string s1, string s2, string s3)
        {
            return text.Contains(s1) && text.Contains(s2) && text.Contains(s3);
        }

        static void Main()
        {
            string text = "This is a sample text containing S1, S2, and, obiously... S3 in any order.";
            string s1 = "S2";
            string s2 = "S1";
            string s3 = "S3";

            string result = FindShortestSubstring(text, s1, s2, s3);

            Console.WriteLine($"Shortest substring containing {s1}, {s2}, and {s3}: {result}");
        }
    }

}
