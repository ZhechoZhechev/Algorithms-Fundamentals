using System;

namespace _3._Generating_0_and_1s__Vectors
{
    internal class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine()!);

            VectorsGenerator(new int[n], 0);
        }

        private static void VectorsGenerator(int[] vector, int index)
        {
            if (index == vector.Length) 
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int i = 0; i <= 1; i++) 
            {
                vector[index] = i;
                VectorsGenerator(vector, index +1);
            }
        }
    }
}