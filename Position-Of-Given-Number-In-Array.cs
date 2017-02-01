using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionOfGivenNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1,2,3,4,5};
            Console.WriteLine("Enter the number to be search from 1-5");
            int search = Convert.ToInt32(Console.ReadLine());

            int result = Position(array, search);
            if ( result == -1)
            {
                Console.WriteLine("Not Found");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Found at {0} position",result);
                Console.ReadLine();
            }
        }

        private static int Position(int[] arr,int ToBeSearched)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] == ToBeSearched)
                {
                    return i+1;
                }
            }
            return -1;
        }
    }
}
