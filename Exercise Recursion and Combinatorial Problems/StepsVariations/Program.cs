using System.Net.Http.Headers;

namespace StepsVariations;
internal class Program
{
    private static Dictionary<long, long> cache = new Dictionary<long, long>();
    static void Main()
    {
        Console.WriteLine("Please, enter steps count:");
        long stepsCount = int.Parse(Console.ReadLine());

        long result = StepsVariations(stepsCount);
        Console.WriteLine(result);
    }

    private static long StepsVariations(long stepsCount)
    {
        if (cache.ContainsKey(stepsCount))
        {
            return cache[stepsCount];
        }

        if (stepsCount == 1) return 1;
        if (stepsCount == 2) return 2;

        var result = StepsVariations(stepsCount - 1) + StepsVariations(stepsCount - 2);
        cache[stepsCount] = result;
        return result;
    }
}
