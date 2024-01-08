
namespace StepsVariations;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter steps count:");
        int stepsCount = int.Parse(Console.ReadLine());

        long result = StepsVariations(stepsCount);
        Console.WriteLine(result);
    }

    private static long StepsVariations(int stepsCount)
    {
        if (stepsCount == 1) return 1;
        if (stepsCount == 2) return 2;

        return StepsVariations(stepsCount - 1) + StepsVariations(stepsCount - 2);
    }
}
