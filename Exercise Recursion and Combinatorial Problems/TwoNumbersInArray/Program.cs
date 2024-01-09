
namespace TwoNumbersInArray;

internal class Program
{
    static void Main()
    {
        int[] arr = { 5, 14, 23, 1, 3, 82, 33, 2, 4 };

        int num = 6;


        var result1 = CouplesWithSumEqualToNum(num, arr);
        Console.WriteLine($"Total count of couple number with sum equals the num is {result1.Count}:");
        foreach (var array in result1)
        {
            Console.WriteLine($"{array[0]} - {array[1]}");
        }

        var result = CouplesWithSumLessThanNum(num, arr);
        Console.WriteLine($"Total count of couple number with sum less that the num is {result.Count}:");
        foreach (var array in result)
        {
            Console.WriteLine($"{array[0]} - {array[1]}");
        }
    }

    private static List<int[]> CouplesWithSumEqualToNum(int num, int[] arr)
    {
        int[] sortedArr = arr.Order().ToArray();
        List<int[]> couples = new List<int[]>();

        for (int i = 0; i < sortedArr.Length; i++)
        {
            int left = i;
            int right = sortedArr.Length - 1;
            while (left < right)
            {
                int sum = sortedArr[left] + sortedArr[right];

                if (sum == num)
                {
                    couples.Add(new int[] { sortedArr[left], sortedArr[right] });
                    couples.Add(new int[] { sortedArr[right], sortedArr[left] });
                    break;
                }
                else if (sum < num) 
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return couples;
    }

    private static List<int[]> CouplesWithSumLessThanNum(int theNumber, int[] arr)
    {
        int[] sortedArr = arr.Order().ToArray();
        List<int[]> couples = new List<int[]>();

        for (int i = 0; i < sortedArr.Length; i++)
        {
            for (int j = 0; j < sortedArr.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if ((sortedArr[i] + sortedArr[j]) <= theNumber)
                {
                    couples.Add(new int[] { sortedArr[i], sortedArr[j] });
                }
                else
                {
                    break;
                }
            }
        }

        return couples;
    }
}
