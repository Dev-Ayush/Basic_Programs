using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Check it's Palindrome or not");
            int num = Convert.ToInt32(Console.ReadLine());
            if(IsPalindrome(num)== true)
            {
                Console.WriteLine("It's a Palindrome Number");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("It's Not !");
                Console.ReadKey();
            }
        }

        public static bool IsPalindrome(int number)
        {
            if(number == Reverse(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Reverse(int GivenNumber)
        {
            int rev_num = 0;
            while(GivenNumber>0)
            {
                int r = GivenNumber % 10;
                rev_num = rev_num * 10 + r;
                GivenNumber /= 10;
            }
            return rev_num;
        }
    }
}
