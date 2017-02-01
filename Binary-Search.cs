using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[100];
            bool isNum = false;
            int sizenum;

            Console.WriteLine("Enter the limit of the array:");
            string sizeString = Console.ReadLine();
            isNum = Int32.TryParse(sizeString, out sizenum);

            if(isNum)
            {
                Console.WriteLine("Enter array values (numeric only) in ascending order");

                for(int i=0;i<sizenum;i++)
                {
                    int tempValue;
                    string arrayItem = Console.ReadLine();
                    isNum = Int32.TryParse(arrayItem,out tempValue);

                    if(isNum)
                    {
                        numArray[i] = tempValue;
                    }
                    else
                    {
                        Console.WriteLine("You entered a non-numeric value !");
                        break;
                    }
                }

                Console.WriteLine("Enter search value numeric only");
                int searchNum;
                string searchString = Console.ReadLine();
                isNum = Int32.TryParse(searchString,out searchNum);

                if(isNum)
                {
                    int lowNum = 0;
                    int highNum = sizenum - 1;

                    while(lowNum<=highNum)
                    {
                        int midNum = (lowNum + highNum) / 2;
                        if(searchNum<numArray[midNum])
                        {
                            highNum = midNum - 1;
                        }
                        else if (searchNum > numArray[midNum])
                        {
                            lowNum = midNum + 1;
                        }
                        else if(searchNum == numArray[midNum])
                        {
                            Console.WriteLine("Search Successful !");
                            Console.WriteLine("value {0} found at location {1}\n",searchNum,numArray[midNum]);
                            Console.ReadLine();
                            return;
                        }
                    }

                    Console.WriteLine("Value {0} was not found ",searchNum);
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Search value must be numeric!");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("You must enter a numeric value!");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
