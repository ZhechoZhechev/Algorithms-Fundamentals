namespace OnlyOneNumRepeats;

internal class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 4, 7, 8 };

        //01
        //Dictionary<int, int> numsCount = new Dictionary<int, int>();

        //foreach (int num in arr) 
        //{
        //    if (numsCount.ContainsKey(num))
        //    {
        //        numsCount[num]++;
        //    }
        //    else
        //    {
        //        numsCount[num] = 1;
        //    }
        //}

        //foreach (KeyValuePair<int, int> kvp in numsCount) 
        //{
        //    if (kvp.Value > 1)
        //    {
        //        Console.WriteLine(kvp.Key);
        //    }
        //}

        //02

        int n = arr.Length;

        int expectedSum = (n * (n - 1)) / 2;
        int actualSum = arr.ToList().Sum();
        int repeatingNum = actualSum - expectedSum;

        Console.WriteLine($"The repeating number is: {repeatingNum}");
    }
}
