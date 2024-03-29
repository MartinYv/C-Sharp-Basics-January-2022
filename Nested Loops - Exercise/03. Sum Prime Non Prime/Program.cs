﻿using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            int number = 0;


            while (input != "stop")
            {
                number = int.Parse(input);

                if (number< 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;


                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                    if (isPrime)
                    {
                        primeSum += number;
                    }
                    else
                    {
                        nonPrimeSum += number;
                    }
                input = Console.ReadLine();
                }
            
           Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");






        }
    }
}
