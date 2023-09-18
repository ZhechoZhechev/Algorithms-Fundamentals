namespace FibonacciLinear
{
    public class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            long firstNumber = 0;
            long secondNumber = 1;

            var fibSequence = new List<long>() { 0, 1 };

            for (int i = 2; i < num; i++)
            {
                long nextNumber = firstNumber + secondNumber;

                fibSequence.Add(nextNumber);

                firstNumber = secondNumber;
                secondNumber = nextNumber;

            }

            Console.WriteLine(string.Join(", ", fibSequence));
        }
    }
}