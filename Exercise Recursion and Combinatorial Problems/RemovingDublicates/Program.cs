

namespace RemovingDublicates;

internal class Program
{
    static void Main()
    {
        int[] multiset = { 1, 3, 2, 3, 2, 3 };

        HashSet<int> set = RemoveWhenUnsortedMultiset(multiset);
        Console.WriteLine(string.Join(", ", set));

        int[] multiset2 = { 1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 4 };

        List<int> sortedSet = RemoveWhenSortedMultiset(multiset2);
        Console.WriteLine(string.Join(", ", sortedSet));
    }

    private static List<int> RemoveWhenSortedMultiset(int[] multiset)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < multiset.Length; i++)
        {
            if (i == 0 || multiset[i] != multiset[i - 1])
            {
                result.Add(multiset[i]);
            }
        }

        return result;
    }

    private static HashSet<int> RemoveWhenUnsortedMultiset(int[] multiset)
    {
        return new HashSet<int>(multiset);
    }
}
