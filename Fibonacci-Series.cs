using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the series");
            int length = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<length;i++)
            {
                Console.Write("{0} ",FibonacciSeries(i));
            }
            Console.ReadKey();
        }

        private static int FibonacciSeries(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
