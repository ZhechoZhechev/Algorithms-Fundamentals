
namespace MissingNaturalNumber;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 4, 5, 2, 7, 6, 8 };

        int missingNum = FindMissingNumber(numbers);
        Console.WriteLine(missingNum);
    }

    private static int FindMissingNumber(int[] numbers)
    {
        HashSet<int> hashNumbers = new HashSet<int>(numbers);

        for (int i = 1; i <= hashNumbers.Count; i++)
        {
            if (!hashNumbers.Contains(i)) return i;
        }
        return -1;
    }
}
