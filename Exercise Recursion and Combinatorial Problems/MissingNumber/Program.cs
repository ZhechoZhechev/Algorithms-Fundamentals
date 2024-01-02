namespace MissingNumber;

internal class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };

        int n = arr.Length + 1;

        int expectedSum = (n * (n + 1)) / 2;
        int actualSum = arr.ToList().Sum();
        int repeatingNum = expectedSum - actualSum;

        Console.WriteLine($"The missing number is: {repeatingNum}");
    }
}
