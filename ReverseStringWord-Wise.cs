using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringWord_Wise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you string separated by spaces");
            string InputValue = Console.ReadLine();
            string items = string.Join(" ", ReversedString(InputValue));
            Console.Write(items);
            Console.ReadKey();
        }

        private static List<string> ReversedString(string inputValue)
        {
            string[] s = inputValue.Split(' ');
            List<string> result = new List<string>();
            int temp = s.Length - 1;
            for (int i=temp;i>=0;i--)
            {
                result.Add(s[temp] + "" + ' ');
                --temp;
            }
            return result;
        }
    }
}
