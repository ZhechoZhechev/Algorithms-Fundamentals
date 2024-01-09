using System.Security.Cryptography.X509Certificates;

namespace WhenLightBulbsBreak;

internal class Program
{
    private static int num;

    static void Main()
    {
        Random random = new Random();
        num = random.Next(1, 101);

        int numFound = FindTheNum(1, 100);
        Console.WriteLine(numFound);
    }

    private static int FindTheNum(int lower, int upper)
    {
        while (lower < upper)
        {
            int mid = (lower + upper) / 2;

            if (mid == num)
            {
               return mid;
            }
            else if (mid > num)
            {
                upper = mid;
            }
            else
            {
                lower = mid;
            }

        }

        return 0;
    }
}
