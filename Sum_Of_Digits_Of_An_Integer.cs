using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum=0, r = 0;
            while(number!=0)
            {
                r = number % 10;
                number = number / 10;
                sum = sum + r;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
