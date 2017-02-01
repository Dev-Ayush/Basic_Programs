using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {45,65,45,96,15};
            Console.WriteLine(get_smallest(arr));
            Console.ReadKey();
        }

        private static int get_smallest(int[] arrr)
        {
            int smallest = arrr[0];
            for(int i=1;i<arrr.Length;i++)
            {
                if(arrr[i]<smallest)
                {
                    smallest = arrr[i];
                }
            }
            return smallest;
        }
    }
}
