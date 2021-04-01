using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = System.Math.Max(5, 10);
            Console.WriteLine(max);

            int min = System.Math.Min(5, 10);
            Console.WriteLine(min);

            double sqrt = System.Math.Sqrt(64);
            Console.WriteLine(sqrt);

            double abs = System.Math.Abs(-4.7);
            Console.WriteLine(abs);

            double round = System.Math.Round(9.99);
            Console.WriteLine(round);
        }
    }
}
