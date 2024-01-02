namespace NonrepeatingElementInArray;

internal class Program
{
    static void Main()
    {
        int[] arr = { 1, 4, 2, 1, 3, 4, 2, 5, 5 };


        //01
        //Array.Sort(arr);

        //for (int i = 0; i < arr.Length; i += 2)
        //{
        //    if (arr[i] != arr[i + 1])
        //    {
        //        Console.WriteLine(arr[i]);
        //        break;
        //    }

        //}

        //02
        //Dictionary<int, int> numsCount = new Dictionary<int, int>();
        //foreach (var num in arr)
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

        //foreach (var kvp in numsCount)
        //{
        //    if (kvp.Value == 1)
        //    {
        //        Console.WriteLine(kvp.Key);
        //    }
        //}

        //03
        int result = 0;

        foreach (int num in arr)
        {
            result ^= num;
        }

        Console.WriteLine(result);

    }

}
