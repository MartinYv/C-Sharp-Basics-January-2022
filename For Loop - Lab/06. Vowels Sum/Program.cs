﻿using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string text = Console.ReadLine();

            double sum = 0;

            for (int i = 0; i < text.Length; i++)
            {//a e i o u
                char currnetSimbol = text[i];
            
                switch (currnetSimbol)
                {
                    case 'a':
                        sum += 1;
                            break;
                    case 'e':
                        sum += 2;
                            break;
                    case 'i':
                        sum += 3;
                            break;
                    case 'o':
                        sum += 4;
                            break;
                    case 'u':
                        sum += 5;
                            break;

                }                  
            }
            Console.WriteLine(sum);
        }
    }
}