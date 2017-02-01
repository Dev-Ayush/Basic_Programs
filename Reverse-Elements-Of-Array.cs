using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {1,2,3,4,5};
            ReverseArray(array);
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();

        }

        private static void ReverseArray(int[] arr)
        {
            int array_length = arr.Length;
            int mid = (array_length) / 2;
            for (int i=0;i<=mid;i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
                array_length--;
            }
        }
    }
}
