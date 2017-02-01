using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, remainder, number = 0;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i=number;i>0;i=i/10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }

            if(sum == number)
            {
                Console.WriteLine("Armstrong Number");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
                Console.ReadLine();
            }
        }
    }
}
