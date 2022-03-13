using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sahe(5,15));
            
        }
        static double Sahe(int r)
        {
            int p = 3;
            int S = p * r * r;
            return S; 
        }

        static double Sahe(double a, double b)
        {
            double S = a * b;
            return S;
        }



    }
}
