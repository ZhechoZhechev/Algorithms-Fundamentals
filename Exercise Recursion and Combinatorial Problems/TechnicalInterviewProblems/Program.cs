namespace UpsAndDowns;

internal class Program
{
    private static int numebеrWeSearch;

    static void Main()
    {
        numebеrWeSearch = 13;

        Console.WriteLine(FindTheNumber(1, 100));
    }

    private static int FindTheNumber(int left, int right)
    {
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (Guess(mid) == 0)
            {
                return mid;
            }
            else if (Guess(mid) == 1)
            {
                left = mid + 1;
            }
            else if (Guess(mid) == -1)
            {
                right = mid - 1;
            }
        }
        return -1;
    }

    private static int Guess(int number)
    {
        if (number == numebеrWeSearch) return 0;
        else if (number < numebеrWeSearch) return 1;
        else return -1;
    }
}
