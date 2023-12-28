namespace TripletsWithSumZero;

internal class Program
{
    static void Main()
    {
        int[] arr = { 7, -5, 2, 3, -4, -4, 2, 0, 1, -6 };
        Array.Sort(arr);

        int n = arr.Length;
        int count = 0;

        //for (int i = 0; i < n - 2; i++)
        //{
        //    for (int j = i + 1; j < n - 1; j++)
        //    {
        //        for (int k = j + 1; k < n; k++)
        //        {
        //            if (arr[i] + arr[j] + arr[k] == 0)
        //            {
        //                Console.Write(arr[i]);
        //                Console.Write(" ");
        //                Console.Write(arr[j]);
        //                Console.Write(" ");
        //                Console.Write(arr[k]);
        //                Console.Write("\n");
        //                count++;
        //            }
        //        }
        //    }
        //}

        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && arr[i] == arr[i - 1])
                continue;

            int left = i + 1;
            int right = arr.Length - 1;
            while (left < right)
            {
                int sum = arr[i] + arr[left] + arr[right];

                if (sum == 0)
                {
                    Console.Write(arr[i]);
                    Console.Write(" ");
                    Console.Write(arr[left]);
                    Console.Write(" ");
                    Console.Write(arr[right]);
                    Console.Write("\n");
                    count++;
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }


        if (count > 0)
        {
            Console.WriteLine($"Yes, there are 3 elements with sum zero, and their count is {count}.");
        }
        else
        {
            Console.WriteLine("There are no 3 elements with sum zero.");
        }

    }
}
