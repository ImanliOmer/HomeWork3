using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Elements(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result);
        }

        static int Elements(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
