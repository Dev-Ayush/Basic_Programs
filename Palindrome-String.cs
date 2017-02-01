using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = "";
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            if(PalindromeString(s))
            {
                Console.WriteLine("Success");
                Console.ReadLine();
            }
            //for(int i=s.Length-1;i>0;i--)
            //{
            //    reverse = s[i].ToString();
            //}

            //if(s == reverse)
            //{
            //    Console.WriteLine("Palindrome String");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Not a Palindrome String");
            //    Console.ReadLine();
            //}
        }

        private static bool PalindromeString(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while(i<j)
            {
                if (str[i] != str[j])
                    return false;

                i++;
                j--;
            }
            return true;
        }
    }
}
