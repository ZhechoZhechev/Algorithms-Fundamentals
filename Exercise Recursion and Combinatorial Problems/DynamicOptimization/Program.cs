namespace DynamicOptimization;

class Program
{
    static int N, M;
    static bool[] vis = new bool[N];
    static long[] dyn = new long[N];

    static long Partition(long remaining)
    {
        if (remaining == 0)
            return 1;
        if (remaining < M)
            return 0;
        if (vis[remaining])
            return dyn[remaining];

        long ans = 0;
        for (long partitionSize = M; partitionSize <= remaining; partitionSize++)
            ans += Partition(remaining - partitionSize);

        vis[remaining] = true;
        return dyn[remaining] = ans;
    }

    static void Main()
    {
        N = 1000;
        M = 250;

        long ways = Partition(N);

        Console.WriteLine($"Number of ways to partition: {ways}");
    }
}
