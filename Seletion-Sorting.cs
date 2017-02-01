using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 15,48,75,652,23};
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }

            SelectionSort(arr);
            Console.WriteLine("The sorted array are as follows:");
            foreach (int a in arr)
            {
                
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

        private static void SelectionSort(int[] array)
        {
            int index = 0;
            for(int i=0;i<array.Length;i++)
            {
                int small_num = array[i];
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<small_num)
                    {
                        small_num = array[j];
                        index = j;
                    }
                }
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
    }
}
