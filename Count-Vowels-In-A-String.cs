using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowelsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string dummy = "ghvghrdtghhutswxghurkjkltygbndffvghderxfghjgfexfvgmcgioioeioeieoovovoaaoaoaoao";
            char[] array = dummy.ToCharArray();
            int vowel_counter = 0;
            for (int i=0;i<array.Length;i++)
            {
                if(array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u' || 
                    array[i] == 'A' || array[i] == 'E' || array[i] == 'I' || array[i] == 'O' || array[i] == 'U' )
                {
                    vowel_counter++;
                }
            }

            Console.WriteLine(vowel_counter);
            Console.ReadLine();
        }
    }
}
