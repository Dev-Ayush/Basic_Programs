using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("First Number is {0} && Second Numberis {1}",b,a);
            Console.WriteLine(a + "," + b);
            Console.ReadLine();
        }
    }
}
