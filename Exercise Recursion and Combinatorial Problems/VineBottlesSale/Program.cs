namespace VineBottlesSale
{
    internal class Program
    {

        static int[] price;
        static int[,] dyn;

        static void Main()
        {
            price = new int[] { 2, 4, 6,};
            int n = price.Length;

            dyn = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dyn[i, j] = -1;
                }
            }

            int result = Recurse(0, n - 1, 1);
            Console.WriteLine(result);
        }

        static int Recurse(int left, int right, int year)
        {
            if (left > right)
                return 0;

            if (dyn[left, right] != -1)
                return dyn[left, right];

            int winLeft = Recurse(left + 1, right, year + 1) + year * price[left];
            int winRight = Recurse(left, right - 1, year + 1) + year * price[right];

            return dyn[left, right] = Math.Max(winLeft, winRight);
        }
    }
}
