using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersFrom_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPrime = true;
            Console.WriteLine("Enter range");
            int range = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Nnumbers are: ");
            for (int i=2; i <=range;i++)
            {
                for(int j=2;j<=range;j++)
                {
                    if(i!=j && i%j==0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if(IsPrime)
                {
                    Console.Write("\t" + i);
                }
                IsPrime = true;
            }
            Console.ReadKey();
        }
    }
}
