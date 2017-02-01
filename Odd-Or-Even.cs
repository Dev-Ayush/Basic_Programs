using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(IsEven(number) == true)
            {
                Console.WriteLine("Even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.ReadLine();
            }
        }

        private static bool IsEven(int num)
        {
            return (num % 2 == 0);
        }
    }
}
