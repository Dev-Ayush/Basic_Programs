using System;

namespace BubbeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] {5,4,9,3,1,7,6};
            int temp;
            Console.WriteLine("The arrays are as follows: ");
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }

            //Sorting Started
            for(int write=0;write<arr.Length;write++)
            {
                for(int sort=0;sort<arr.Length-1;sort++)
                {
                    if(arr[sort] > arr[sort+1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            Console.WriteLine("The sorted array are as follws:");
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
