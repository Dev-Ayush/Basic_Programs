using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == SumOfDivisiors(num))
            {
                Console.WriteLine("It's a Perfect Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It's NOT a Perfect Number");
                Console.ReadLine();
            }
        }

        private static int SumOfDivisiors(int number)
        {
            int sum = 0;
            for(int i=1;i<number;i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
