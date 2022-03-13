using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repeat(10, () => Console.Write("Ha!"));
        }


        public static void Repeat(int count, Action word)
            
        {
            for (int i = 0; i < count; i++)
            {
                word();
            }
        }


    }
}
