
namespace ShufflingNumbers;

internal class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };

        SuffleArray(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    private static void SuffleArray(int[] arr)
    {
        Random rnd = new Random();

        for (int i = arr.Length - 1; i > 0; i--)
        {
            int newIndex = rnd.Next(0, i + 1);

            Swap(arr, i, newIndex);
        }
    }

    private static void Swap(int[] arr, int i, int newIndex)
    {
        (arr[newIndex], arr[i]) = (arr[i], arr[newIndex]);
    }
}
