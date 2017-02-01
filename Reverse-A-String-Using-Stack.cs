using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            Console.WriteLine(ReverseString(s));
            

            Console.WriteLine("------------------------------------");
            Console.WriteLine(ReverserString2(s));
            Console.ReadKey();
        }

        // USING STACK
        private static string ReverseString(string str)
        {
            string revString = null;
            Stack<char> arr = new Stack<char>();
            foreach(char c in str)
            {
                arr.Push(c);
                
            }
            foreach (char c in str)
            {
                revString += arr.Pop();
            }
            return revString;
        }

        private static string ReverserString2(string str)
        {
            char[] chars = new char[str.Length];
            for(int i=0,j=str.Length-1;i<=j;i++,j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
    }
}
