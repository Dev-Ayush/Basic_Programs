using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfN_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for(int i=0;i<=size;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = 0;
            for(int i=0;i<size;i++)
            {
                if(array[i]>largest)
                {
                    largest = array[i];
                }
            }
            Console.Write("Largest Number is: " + largest);
            Console.ReadLine();
        }
    }
}
