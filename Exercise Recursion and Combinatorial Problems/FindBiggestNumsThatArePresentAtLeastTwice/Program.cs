
namespace FindBiggestNumsThatArePresentAtLeastTwice;

internal class Program
{
    static void Main()
    {
        int[] exampleArray = { 5, 5, 8, 8, 8, 12, 12, 12, 3, 7, 7, 2 };

        var result = FindBiggestNumsThatArePresentAtLeastTwice(exampleArray);
    }

    private static object FindBiggestNumsThatArePresentAtLeastTwice(int[] exampleArray)
    {
        SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();

        foreach (int num in exampleArray) 
        {
            if (keyValuePairs.ContainsKey(num)) 
            {
                keyValuePairs[num]++;
            }
            else
            {
                keyValuePairs[num] = 1;
            }
        }
        
        return keyValuePairs.Where(x => x.Value >= 2).Select(x => x.Key).TakeLast(2);
    }
}
