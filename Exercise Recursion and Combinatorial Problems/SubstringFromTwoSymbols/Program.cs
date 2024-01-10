namespace SubstringFromTwoSymbols;

internal class Program
{
    static void Main()
    {
        string str = "aababbaacacaacacccaabad";

        var result = Longest2CharSubstring(str);

        string substring = str.Substring(result.Key, result.Value);
        Console.WriteLine($"Longest 2 chars substring is {substring}");
    }

    static KeyValuePair<int, int> Longest2CharSubstring(string str)
    {
        int best = 0; 
        int startAt = 0;
        int inCount = 0;
        int left = 0;

        KeyValuePair<int, int> startsAtAndLenght;
        int[] cnt = new int[256];

        for (int right = 0; right < str.Length; right++)
        {
            int rightAsAscii = str[right];
            if (cnt[rightAsAscii]++ == 0)
                inCount++;

            while (inCount > 2)
            {
                if (--cnt[str[left++]] == 0)
                    inCount--;
            }

            if (best < right - left + 1)
            {
                best = right - left + 1;
                startAt = left;
            }
        }
        startsAtAndLenght = new KeyValuePair<int, int>(startAt, best);
        return startsAtAndLenght;
    }
}
