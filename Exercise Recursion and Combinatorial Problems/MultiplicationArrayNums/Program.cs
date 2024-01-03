using System;

class Program
{
    static void Main()
    {
        int[] inputArray = { 1, 2, 3, 4 };
        int[] resultArray = ProductExceptSelf(inputArray);

        Console.WriteLine("Result Array: " + string.Join(", ", resultArray));
    }

    private static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] leftProducts = new int[n];
        int[] rightProducts = new int[n];

        leftProducts[0] = 1;

        for (int i = 1; i < n; i++)
        {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        rightProducts[n - 1] = 1;

        for (int i = n - 2; i >= 0; i--)
        {
            rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
        }

        int[] resultArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            resultArray[i] = leftProducts[i] * rightProducts[i];
        }

        return resultArray;
    }
}
