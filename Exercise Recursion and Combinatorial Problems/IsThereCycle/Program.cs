namespace IsThereCycle
{
    public class Node 
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            this.Value = value;
            Next = null;
        }

    }
    internal class Program
    {
        static void Main()
        {
            Node ListWithoutCycle = new Node(1);
            ListWithoutCycle.Next = new Node(2);
            ListWithoutCycle.Next.Next = new Node(3);
            ListWithoutCycle.Next.Next.Next = ListWithoutCycle;

            bool result = IsThereACycle(ListWithoutCycle);

            Console.WriteLine(result);

        }

        private static bool IsThereACycle(Node node) 
        {
            if (node == null && node.Next == null)
            {
                return false;
            }

            Node slowPointer = node;
            Node fastPointer = node.Next;

            while (slowPointer != null && fastPointer != null) 
            {
                if (slowPointer == fastPointer)
                {
                    return true;
                }

                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
            }

            return false;
        }
    }
}
