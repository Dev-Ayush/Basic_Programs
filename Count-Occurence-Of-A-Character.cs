﻿using System;


namespace CountOccurenceOfACharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "MYNameIsAyushKumarSingh";

            while(input.Length>0)
            {
                Console.Write(input[0] + ": ");
                int count = 0;
                for(int i=0;i<input.Length;i++)
                {
                    if(input[0] == input[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
