using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int f3=0;
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            for(int i=1;i<limit;i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }

            Console.ReadKey();
        }
    }
}
