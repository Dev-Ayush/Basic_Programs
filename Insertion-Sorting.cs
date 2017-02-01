using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 46,84,21,95,32};
            int array_size = array.Length-1;
            Console.WriteLine("Before Sorting, the values are as follows");
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            InsertionSort(array,array_size);
            Console.WriteLine("After Sorting are as follows: ");
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

        private static void InsertionSort(int[] arr, int size)
        {
            //for(int i=1;i<size;i++)
            //{
            //    int temp = arr[i];
            //    int j = i - 1;
            //    while ((temp< arr[j]) && j>=0)
            //    {
            //        arr[j + 1] = arr[j];
            //        j--;
            //    }
            //    arr[j + 1] = temp;
            //}

            int i, j;
            for (i = 1; i < size; i++)
            {
                int item = arr[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
    }
}
