namespace IntervalWithMaxSum;

internal class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, -5, 6, -1, 4, -2, 3, -40, -2, 3 };

        Tuple<int, int, int> result = FindMaxSumSubarray(arr);

        Console.WriteLine($"Start Index: {result.Item1}, End Index: {result.Item2}, Max Sum: {result.Item3}");

        Console.WriteLine("The subarray is:");
        List<int> subarray = new List<int>();
        for ( int i = result.Item1; i <= result.Item2; i++ ) 
        {
            subarray.Add(arr[i]);
        }
        Console.WriteLine(string.Join( ", ", subarray ));

    }

    private static Tuple<int, int, int> FindMaxSumSubarray(int[] arr)
    {
        int currentSum = 0;
        int maxsum = int.MinValue;
        int startIndex = 0;
        int endIndex = - 1;
        int currentStartIndex = 0;

        for (int i = 0; i < arr.Length; i++) 
        {
            currentSum += arr[i];

            if (currentSum > maxsum) 
            {
                maxsum = currentSum;
                startIndex = currentStartIndex;
                endIndex = i;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                currentStartIndex = i +1;
            }
        }

        return Tuple.Create(startIndex, endIndex, maxsum);
    }
}
