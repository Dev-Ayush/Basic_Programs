using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find it's factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            int total = 1;
            for(int i=number;i>0;i--)
            {
                total *= i;
            }
            Console.WriteLine("factorials of {0} is: {1}",number,total);
            Console.ReadLine();
        }
    }
}
