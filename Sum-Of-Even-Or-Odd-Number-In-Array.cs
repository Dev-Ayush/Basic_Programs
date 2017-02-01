using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenOrOddNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numers of array");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] array = Array.ConvertAll(s, ss => int.Parse(ss));
            int EvenCounter = 0;
            int OddCounter = 0;

            for(int i=0;i<array.Length;i++)
            {
                if(array[i] % 2 ==0)
                {
                    EvenCounter++;
                }
                else
                {
                    OddCounter++;
                }
            }

            Console.WriteLine("Total Even Numbers are :" + EvenCounter + " and total Odd Numbers are : " + OddCounter);
            Console.ReadLine();
        }
    }
}
