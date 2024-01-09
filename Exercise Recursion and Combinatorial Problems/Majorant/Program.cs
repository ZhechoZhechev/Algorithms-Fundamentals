
namespace Majorant;

internal class Program
{
    static void Main()
    {
        int[] array = { 2, 3, 4, 2, 2, 5, 2};

        int majorityElement = FindMajorityElement(array);
        int majorityElement1 = FindMajorityElement1(array);

        if (majorityElement1 == 0)
            Console.WriteLine("There is no majorant element");
        else
            Console.WriteLine(majorityElement1);
    }

    private static int FindMajorityElement1(int[] array)
    {
        Stack<int> stack = new Stack<int>();

        foreach (int number in array) 
        {
            if (stack.Count == 0)
            {
                stack.Push(number);
            }
            else if(stack.Peek() == number)
            {
                stack.Push(number);
            }
            else
            {
                stack.Pop();
            }
        }

        int count = 0;
        int majorant = 0;
        foreach (var num in stack)
        {
            foreach(var number in array)
            {
                if (num == number)
                {
                    count++;
                }

                if(count >= Math.Ceiling(array.Length / (double)2))
                {
                    majorant = number;
                }
            }
        }

        return majorant;
    }

    private static int FindMajorityElement(int[] array)
    {
        Dictionary<int, int> occurances = new Dictionary<int, int>();
        foreach (int num in array) 
        {
            if (occurances.ContainsKey(num))
            {
                occurances[num]++;
            }
            else 
            {
                occurances[num] = 1; 
            }
        }

        return occurances.Where(x => x.Value >= Math.Ceiling(array.Length / (double)2)).Select(x => x.Key).FirstOrDefault();
    }
}
