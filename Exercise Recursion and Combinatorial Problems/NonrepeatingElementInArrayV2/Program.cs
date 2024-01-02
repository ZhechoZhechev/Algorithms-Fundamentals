namespace NonrepeatingElementInArrayV2
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 1, 2, 2, 3, 4, 4, 5 };

            //01
            //Array.Sort(arr);

            //int counter = 0;
            //while (counter < arr.Length - 1)
            //{
            //    if (arr[counter] == arr[counter + 1])
            //    {
            //        counter += 2;
            //    }
            //    else if (arr[counter] != arr[counter + 1])
            //    {
            //        Console.WriteLine(arr[counter]);
            //        counter++;
            //    }

            //    if (counter == arr.Length - 1
            //        && arr[counter - 2] != arr[arr.Length - 1])
            //    {
            //        Console.WriteLine(arr[arr.Length - 1]);
            //    }
            //}

            //02
            Dictionary<int, int> numsCount = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (numsCount.ContainsKey(num))
                {
                    numsCount[num]++;
                }
                else
                {
                    numsCount[num] = 1;
                }
            }

            foreach (var kvp in numsCount)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine(kvp.Key);
                }
            }

        }
    }
}
