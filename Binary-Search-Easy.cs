using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            // int[] arrayElements = new int[arraySize];
            List<int> arrayElements2 = new List<int>();

            Console.WriteLine("enter the values");
            for(int i=0;i<arraySize;i++)
            {
                string temp = Console.ReadLine();
                arrayElements2.Add(Convert.ToInt32(temp));

            }

            Console.WriteLine("Enter the number to search");
            int numSearch = Convert.ToInt32(Console.ReadLine());

            int index = SearchResult(arrayElements2, numSearch);

            if ( index == -1)
            {
                Console.WriteLine("Not FOUND");
            }
            else
            {
                Console.WriteLine("Your entered number {0} found at location {1}",numSearch, index+1);
                Console.ReadLine();
            }

        }

        private static int SearchResult(List<int> val,int NumberToBeSearched)
        {
            int low = val[0];
            int max = val[val.Count-1];

            while(low<=max)
            {
                int mid = (low + max) / 2;
                if(NumberToBeSearched == val[mid])
                {
                    return mid;
                }
                if (NumberToBeSearched < val[mid])
                    max = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
