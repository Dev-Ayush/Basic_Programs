using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int quotion;
            string rem = "";
            while(number>=1)
            {
                quotion = number / 2;
                rem += (number % 2).ToString();
                number = quotion;
            }
            string bin = "";
            for (int i=rem.Length - 1; i >= 0;i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
            Console.Read();
        }
    }
}
