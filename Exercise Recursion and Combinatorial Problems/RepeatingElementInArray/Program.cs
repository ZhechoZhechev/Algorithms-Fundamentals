
namespace RepeatingElementInArray;

internal class Program
{
    static void Main()
    {
        int[] arr = { 5, 3, 1, 4, 2, 3, 7, 6 };

        //Console.WriteLine(ifDuplicateNumViaSort(arr));
        //Console.WriteLine(ifDuplicateNumViaAdditionalArray(arr));
        Console.WriteLine(ifDuplicateNumViaSettingNumsToNegative(arr));

    }

    private static bool ifDuplicateNumViaSettingNumsToNegative(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int index = arr[i] - 1;

            if (arr[index] < 0)
            {
                return true;
            }

            arr[index] = -arr[index];
        }

        return false;
    }

    private static bool ifDuplicateNumViaAdditionalArray(int[] arr)
    {
        int n = arr.Length;
        int[] numbersCount = new int[n];
        for (int i = 0; i < n; i++)
        {
            int currNum = arr[i];
            numbersCount[currNum - 1]++;

            if (numbersCount[currNum - 1] > 1)
            {
                return true;
            }
        }
        return false;
    }

    private static bool ifDuplicateNumViaSort(int[] arr)
    {
        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                return true;
            }
        }
        return false;
    }
}
