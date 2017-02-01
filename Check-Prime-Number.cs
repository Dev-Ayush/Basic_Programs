using System;

namespace CheckPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if it's a Prime Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(IsPrime(num)==true)
            {
                Console.WriteLine("It's a Prime Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It's NOT a Prime Number");
                Console.ReadLine();
            }
        }

        private static bool IsPrime(int num)
        {
            int f_count = 0;
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    f_count++;
                }
            }
            if(f_count==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
