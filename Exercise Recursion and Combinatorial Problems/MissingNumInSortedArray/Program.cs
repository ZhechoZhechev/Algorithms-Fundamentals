
namespace MissingNumInSortedArray;

internal class Program
{
    static void Main()
    {
        int[] arr = { 0, 1, 2, 4, 5, 6, 7 };

        //int result = FindMissingNum(arr);
        int result = FindMissingNumWithBinarySearch(arr);
        Console.WriteLine(result);
    }

    private static int FindMissingNum(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != i)
            {
                return i;
            }
        }
        return arr.Length;
    }

    private static int FindMissingNumWithBinarySearch(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right) 
        {
            int mid = (left + right) / 2;

            if (arr[mid] != mid)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}
